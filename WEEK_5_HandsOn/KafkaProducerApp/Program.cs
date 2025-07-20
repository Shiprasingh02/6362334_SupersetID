using Confluent.Kafka;
using System;
using System.Threading.Tasks;
using static Confluent.Kafka.ConfigPropertyNames;

class Program
{
    static async Task Main(string[] args)
    {   

        var config = new ProducerConfig
        {
            BootstrapServers = "localhost:9092"
        };

        var producer = new ProducerBuilder<Null, string>(config).Build();


        Console.WriteLine("Enter messages to send to Kafka (type 'exit' to quit):");

        while (true)
        {
            string input = Console.ReadLine();
            if (input.ToLower() == "exit") break;

            var result = await producer.ProduceAsync("chat-topic", new Message<Null, string> { Value = input });

            Console.WriteLine($"Message sent to Kafka: {result.TopicPartitionOffset}");
            
        }
    }
}
