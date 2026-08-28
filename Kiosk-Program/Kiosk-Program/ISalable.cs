using System;
using System.Reflection.Metadata.Ecma335;
public interface ISalable
{
    public int[] SaleValue { get; }

    public string PrintSalePoint();
}
