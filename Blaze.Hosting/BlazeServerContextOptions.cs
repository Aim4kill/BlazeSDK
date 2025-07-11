using Blaze.Core;
using EATDF;
using EATDF.Serialization;
using ProtoFire;
using ProtoFire.Tls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Blaze.Hosting;

public class BlazeServerContextOptions
{
    internal Dictionary<ushort, string> BaseErrorNames { get; set; } = new Dictionary<ushort, string>();

    internal List<Type> MappedComponents { get; } = new List<Type>();

    /// <summary>
    /// Configures the base server errors.
    /// </summary>
    /// <typeparam name="T">The server error enum.</typeparam>
    /// <exception cref="ArgumentException">Thrown if the enum does not have an underlying type of ushort.</exception>
    public BlazeServerContextOptions ConfigureServerErrors<T>() where T : Enum
    {
        if (typeof(T).GetEnumUnderlyingType() != typeof(ushort))
            throw new ArgumentException("Server Error enum must be an enum with an underlying type of ushort");

        foreach (var error in Enum.GetValues(typeof(T)))
        {
            ushort errorValue = (ushort)error;
            errorValue |= 0x4000;
            BaseErrorNames[errorValue] = error.ToString() ?? string.Empty;
        }

        return this;
    }

    /// <summary>
    /// Configures the SDK errors.
    /// </summary>
    /// <typeparam name="T">The SDK error enum.</typeparam>
    /// <exception cref="ArgumentException">Thrown if the enum does not have an underlying type of ushort.</exception>
    public BlazeServerContextOptions ConfigureSdkErrors<T>() where T : Enum
    {
        if (typeof(T).GetEnumUnderlyingType() != typeof(ushort))
            throw new ArgumentException("Server Error enum must be an enum with an underlying type of ushort");

        foreach (var error in Enum.GetValues(typeof(T)))
        {
            ushort errorValue = (ushort)error;
            errorValue |= 0x8000;
            BaseErrorNames[errorValue] = error.ToString() ?? string.Empty;
        }

        return this;
    }

    public BlazeServerContextOptions UseEndpoint(IPEndPoint localEndPoint)
    {
        if (localEndPoint == null)
            throw new ArgumentNullException(nameof(localEndPoint));

        EndPoints.Add(localEndPoint);
        return this;
    }

    public BlazeServerContextOptions AddComponent<TComponent>() where TComponent : IBlazeComponent
    {
        MappedComponents.Add(typeof(TComponent));
        return this;
    }

    /// <summary>
    /// The initial end points to listen on.
    /// </summary>
    public IList<IPEndPoint> EndPoints { get; } = new List<IPEndPoint>();

    /// <summary>
    /// The frame encoding to use.
    /// </summary>
    public FrameEncoding FrameEncoding { get; set; } = FrameEncoding.Fire;

    /// <summary>
    /// The serializer to use.
    /// </summary>
    public TdfSerializerType TdfSerializer { get; set; } = TdfSerializerType.Heat2;

    /// <summary>
    /// The registered TDF types used for serialization and deserialization.
    /// </summary>
    public ITdfRegistry TdfRegistry { get; } = new TdfRegistry();

    /// <summary>
    /// The maximum backlog of connections.
    /// </summary>
    public int Backlog { get; set; } = -1;

    /// <summary>
    /// Whether or not to use a secure connection.
    /// </summary>
    public bool Secure { get; set; } = false;

    /// <summary>
    /// The certificate to use for secure connections if enabled
    /// </summary>
    public ProtoSSLCertificate? Certificate { get; set; }
}
