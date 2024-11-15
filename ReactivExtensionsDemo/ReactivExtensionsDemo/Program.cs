
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Threading.Channels;

void basicIntro()
{
    Console.WriteLine("Temel RX kavramları");
    IObservable<int> numbers = Observable.Range(1, 5);

    numbers.Subscribe(
                       n => Console.WriteLine($"Sayı: {n}"),
                       ex => Console.WriteLine($"Hata oluştu: {ex.Message}"),
                       () => Console.WriteLine("İşlem tamamlandı")
                     );


    //Observable nesnesinin olayları:
    var subject = new Subject<string>();
    subject.Subscribe(msg => Console.WriteLine($"Mesaj alındı {msg}"));


    subject.OnNext("Rx kütüphanesi");
    subject.OnNext("İlk olarak");
    subject.OnNext("C# tarafından geliştirildi");
    subject.OnCompleted();
    Console.WriteLine();
}

void operatorExample()
{
    Console.WriteLine("Operatör örnekleri");
    Console.WriteLine("--------------------------");
    Observable.Range(1, 10)
              .Where(n => n % 3 == 0)
              .Select(x => x * x)
              .Subscribe(x => Console.WriteLine(x));

    //Buffer, Take, Interval

    var numberStream = Observable.Interval(TimeSpan.FromMilliseconds(100))
                                 .Take(10)
                                 .Buffer(3)
                                 .Subscribe(numbers =>
                                 {
                                     Console.WriteLine($"Buffer ile gruplanmış: {string.Join(",", numbers)}");
                                 });
    Task.Delay(5000).Wait();
    Console.WriteLine();
}

async void sensorExample()
{
    Console.WriteLine("Sensör okuma demosu");
    Console.WriteLine("----------------------");

    var sensorSubject = new Subject<SensorData>();
    var tempStream = sensorSubject.Buffer(TimeSpan.FromSeconds(2))
                                  .Where(readings => readings.Count() > 0)
                                  .Select(readings =>
                                  {
                                      var avg = readings.Average(r => r.Temperature);
                                      return new
                                      {
                                          AverageTemp = avg,
                                          ReadingCount = readings.Count,
                                          Timesptamp = readings.Last().Timestamp

                                      };

                                  });

    tempStream.Subscribe(
        data => Console.WriteLine($"Ortalama sıcaklık: {data.AverageTemp} C, toplam okuma: {data.ReadingCount} - {data.Timesptamp}"),
        err => Console.WriteLine(err.Message),
        () => Console.WriteLine("İşlem tamamlandı")


        );

   simulateSensorReading(sensorSubject);
}

 void simulateSensorReading(Subject<SensorData> sensorSubject)
{
    var random = new Random();
    for (int i = 0; i < 10; i++)
    {
        var temp = 20 + random.NextDouble() * 5;
        sensorSubject.OnNext(new SensorData
        {
            Temperature = temp,
            Timestamp = DateTime.Now
        });
        Thread.Sleep(500);

    }
    sensorSubject.OnCompleted();
}








basicIntro();
operatorExample();
sensorExample();

public class SensorData
{
    public DateTime Timestamp { get; set; }
    public double Temperature { get; set; }
}

