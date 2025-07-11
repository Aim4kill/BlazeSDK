using Blaze.Core.Internal;
using EATDF.Serialization;
using Microsoft.Extensions.Logging;
using ProtoFire;
using ProtoFire.Tls;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Blaze.Core;

public class BlazeServer
{
    private ProtoFireServer _protoFireSever;
    private BlazeServerConfig _config;
    private ILogger<BlazeServer> _logger;

    public IPEndPoint LocalEndpoint => _protoFireSever.LocalEP;
    public FrameEncoding FrameType => _config.PacketFrameEncoding;
    public ITdfSerializer Serializer => _config.Serializer;
    public IBlazeRouter Router => _config.Router;
    public IBlazeServerCallbacks Callbacks => _config.CallbackHandler;
    public int Backlog => _config.Backlog;
    public bool Secure => _protoFireSever.Secure;
    public bool Started => _protoFireSever.Started;


    public BlazeServer(BlazeServerConfig config, ILogger<BlazeServer> logger)
    {
        _config = config;
        _logger = logger;

        IProtoFireHandler eventHandler = new BlazeServerProtoFireEventHandler(_config, _logger);
        FrameType frameType = _config.PacketFrameEncoding.ToFrameType();


        _protoFireSever = new ProtoFireServer(config.LocalEndpoint, eventHandler, frameType)
        {
            Secure = _config.Secure
        };
    }

    public async Task StartAsync(CancellationToken cancellationToken = default)
    {
        if (_logger.IsEnabled(LogLevel.Information))
        {
            string secure = Secure ? "true" : "false";

            //log multiple liness
            _logger.LogInformation(
@"Starting Blaze server on {0}:
    Backlog: {1}
    Protocol: {2}
    Serializer: {3}
    SSL/TLS: {4}", 
_config.LocalEndpoint, _config.Backlog, _config.PacketFrameEncoding, _config.Serializer.Name, secure);
        }

        Task serverTask;

        try
        {
            // Start task will throw instanly if the server is already started (without awaiting)
            serverTask = _protoFireSever.StartAsync(_config.Backlog, cancellationToken);

            _config.LocalEndpoint.Port = _protoFireSever.Port;

            if (_logger.IsEnabled(LogLevel.Information))
                _logger.LogInformation("Blaze server started successfully on {0}!", _config.LocalEndpoint);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Encountered an error while starting Blaze server!");
            throw;
        }


        await serverTask.ConfigureAwait(false);
    }
}
