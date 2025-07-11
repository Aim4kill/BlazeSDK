using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace Blaze.Core;

public class BlazeRouter : IBlazeRouter
{
    Dictionary<ushort, string> baseErrorNames = new Dictionary<ushort, string>();
    ConcurrentDictionary<ushort, IBlazeComponent> components = new();

    protected void ConfigureServerErrors<T>() where T : Enum
    {
        if (typeof(T).GetEnumUnderlyingType() != typeof(ushort))
            throw new ArgumentException("Server Error enum must be an enum with an underlying type of ushort");
        
        foreach (var error in Enum.GetValues(typeof(T)))
        {
            ushort errorValue = (ushort)error;
            errorValue |= 0x4000;
            baseErrorNames[errorValue] = error.ToString() ?? string.Empty;
        }
    }

    protected void ConfigureSdkErrors<T>() where T : Enum
    {
        if (typeof(T).GetEnumUnderlyingType() != typeof(ushort))
            throw new ArgumentException("Server Error enum must be an enum with an underlying type of ushort");

        foreach (var error in Enum.GetValues(typeof(T)))
        {
            ushort errorValue = (ushort)error;
            errorValue |= 0x8000;
            baseErrorNames[errorValue] = error.ToString() ?? string.Empty;
        }
    }

    public bool AddComponent(IBlazeComponent component)
    {
        return components.TryAdd(component.Id, component);
    }

    public bool AddComponent<TComponent>() where TComponent : IBlazeComponent, new()
    {
        TComponent component = new TComponent();
        return components.TryAdd(component.Id, component);
    }

    public bool RemoveComponent(ushort id) 
    {
        return components.TryRemove(id, out _);
    }

    public bool RemoveComponent(IBlazeComponent component)
    {
        return components.TryRemove(component.Id, out _);
    }

    public bool RemoveComponent(ushort id, [NotNullWhen(true)] out IBlazeComponent? component)
    {
        return components.TryRemove(id, out component);
    }

    public IBlazeComponent? GetComponent(ushort id)
    {
        components.TryGetValue(id, out IBlazeComponent? component);
        return component;
    }

    public string GetErrorName(int errorCode)
    {
        ushort error = (ushort)(errorCode >> 16);

        if ((error & 0xC000) == 0)
        {
            //component error
            ushort componentId = (ushort)(errorCode & 0xFFFF);

            IBlazeComponent? component = GetComponent(componentId);
            if (component != null)
                return component.GetErrorName(error);
        }
        else
        {
            //global error or sdk error
            if (baseErrorNames.TryGetValue(error, out string? name))
                return name;
        }

        return errorCode.ToString();
    }
}
