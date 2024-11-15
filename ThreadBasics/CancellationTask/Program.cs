// See https://aka.ms/new-console-template for more information
async Task longTimeRunning(CancellationToken cancellationToken)
{
    Console.WriteLine("Uzun sürecek olan işlem başlatıldı");
    for (int i = 0; i < 10; i++)
    {
        cancellationToken.ThrowIfCancellationRequested();
        Console.WriteLine($"İşlem devam ediyor... Değer: {i}");
        await Task.Delay(1000);
    }
}


var tokenSource = new CancellationTokenSource();
var token = tokenSource.Token;
//tokenSource.Cancel();
try
{
    
    
   await Task.Run(()=>  longTimeRunning(token), token);
}
catch (OperationCanceledException)
{

    Console.WriteLine("Task iptal edildi");
}





