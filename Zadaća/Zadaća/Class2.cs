using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//lanac odgovornosti
public abstract class Handler
{
    public Handler NextHandler;

    public void SetNextHandler(Handler NextHandler)
    {
        this.NextHandler = NextHandler;
    }
    public abstract void DispatchNote(long requestedAmount);
}

public class HundredHandler : Handler
{
    public override void DispatchNote(long requestedAmount)
    {
        long numberofNotesToBeDispatched = requestedAmount / 100;
        if (numberofNotesToBeDispatched > 0)
        {
            if (numberofNotesToBeDispatched > 1)
            {
                Console.WriteLine(numberofNotesToBeDispatched + " Hundred notes are dispatched by HundredHandler");
            }
            else
            {
                Console.WriteLine(numberofNotesToBeDispatched + " Hundred note is dispatched by HundredHandler");
            }
        }
    }
}
public class TwoHunderedHandler : Handler
{
    public override void DispatchNote(long requestedAmount)
    {
        long numberofNotesToBeDispatched = requestedAmount / 200;
        if(numberofNotesToBeDispatched > 0)
        {
            if (numberofNotesToBeDispatched > 1)
            {
                Console.WriteLine(numberofNotesToBeDispatched + " Two Hundred notes are dispatched by TwoHunderedHandler");
            }
            else
            {
                Console.WriteLine(numberofNotesToBeDispatched + " Two Hundred note is dispatched by TwoHunderedHandler");
            }
        }
        long pendingAmountToBeProcessed = requestedAmount % 200;
        if (pendingAmountToBeProcessed > 0)
        {
            NextHandler.DispatchNote(pendingAmountToBeProcessed);
        }
    }
}
public class FiveHunderedHandler : Handler
{
    public override void DispatchNote(long requestedAmount)
    {
        long numberofNotesToBeDispatched = requestedAmount / 500;
        if (numberofNotesToBeDispatched > 0)
        {
            if (numberofNotesToBeDispatched > 1)
            {
                Console.WriteLine(numberofNotesToBeDispatched + " Five Hundred notes are dispatched by FiveHunderedHandler");
            }
            else
            {
                Console.WriteLine(numberofNotesToBeDispatched + " Five Hundred note is dispatched by FiveHunderedHandler");
            }
        }
        long pendingAmountToBeProcessed = requestedAmount % 500;
        if (pendingAmountToBeProcessed > 0)
        {
            NextHandler.DispatchNote(pendingAmountToBeProcessed);
        }
    }
}
class Program1
{
    public static void Main()
    {
        HundredHandler hundredHandler = new HundredHandler();
        TwoHunderedHandler twoHundredHandler = new TwoHunderedHandler();
        FiveHunderedHandler fiveHundredHandler = new FiveHunderedHandler();

        twoHundredHandler.SetNextHandler(hundredHandler);
        fiveHundredHandler.SetNextHandler(twoHundredHandler);

        fiveHundredHandler.DispatchNote(500);
    }
}
