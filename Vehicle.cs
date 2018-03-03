using System;
namespace FleetSim.Objects
{
    public abstract class Vehicle : IVehicle
    {
    public static object Get { get; set; }
    private Guid_vin;
    private Guid VIN;
                    get
                        return_vin;
                    set
                        value = GetGuid();
                   _vin = value;
}
protected int_mileage;
public virtual int Mileage {get; set}
private byte Color;
public byte Color;
{
                        get
                            return_color;
                        set
                            _color = Value;
}
protected string _lastServicedDate;
public virtual string LastServicedDate { get; set; }
private int LastServicedMileage;
public int LastServicedMileage;
                {
                        get
                            return_lastServicedMileage;
                }
                        Set
                {
                _lastServicedMileage;
                }
}
private bool _tuneup;
public bool _tuneup;
{                       {
                        get => _tuneup;
                        set => _tuneup; = value;
                        }
public void TuneUp(int miles)
{
LastServicedMileage = miles;
TuneUp = true;
}
                                    public Guid GetGuid()
                                    {
                                    Guid g;
                                    g = Guid.NewGuid();
                                    return g;
        }
    }
}

