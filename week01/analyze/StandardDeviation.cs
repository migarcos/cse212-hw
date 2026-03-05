/// <summary>
/// These 3 functions will (in different ways) calculate the standard
/// deviation from a list of numbers.  The standard deviation
/// is defined as the square root of the variance.  The variance is 
/// defined as the average of the squared differences from the mean.
/// </summary>
using System.Diagnostics;
public static class StandardDeviation {
    public static void Run() {
        var numbers = new[] { 600, 470, 170, 430, 300, 456, 199, 578, 234, 400, 150, 630, 540, 230, 550, 240, 380, 560, 199, 499, 376, 586, 265, 476, 432, 390, 253, 197, 589, 456, 489, 298 };
        // Console.WriteLine(StandardDeviation1(numbers)); // Should be 147.322 
        // double time1 = Time(() => StandardDeviation1(numbers), 10000);
        // Console.WriteLine($"StandardDeviation1: {time1:F4} ms");
        var (time1, result1) = TimeAndResult(() => StandardDeviation1(numbers), 10000);
        Console.WriteLine($"StandardDeviation1: {time1:F4} ms, Result: {result1:F6}");

        // Console.WriteLine(StandardDeviation2(numbers)); // Should be 147.322 
        // double time2 = Time(() => StandardDeviation2(numbers), 10000);
        // Console.WriteLine($"StandardDeviation2: {time2:F4} ms");
        var result2 = TimeAndResult2(() => StandardDeviation2(numbers), 10000);
        Console.WriteLine($"StandardDeviation2: {result2.TimeMs:F4} ms, Result: {result2.Result:F6}");

        // Console.WriteLine(StandardDeviation3(numbers)); // Should be 147.322 
        // double time3 = Time(() => StandardDeviation3(numbers), 10000);
        // Console.WriteLine($"StandardDeviation3: {time3:F4} ms");
        var result3 = TimeAndResult2(() => StandardDeviation3(numbers), 10000);
        Console.WriteLine($"StandardDeviation3: {result3.TimeMs:F4} ms, Result: {result3.Result:F6}");
    }

    private static double Time(Action executeAlgorithm, int times) {
        var sw = Stopwatch.StartNew();
        for (var i = 0; i < times; ++i) {
            executeAlgorithm();
        }

        sw.Stop();
        return sw.Elapsed.TotalMilliseconds / times;
    }

    private static (double timeMs, double result) TimeAndResult(Func<double> executeAlgorithm, int times) {
        var sw = Stopwatch.StartNew();
        double result = 0;
        
        for (var i = 0; i < times; ++i) {
            result = executeAlgorithm(); // Ejecuta y guarda el resultado
        }
        
        sw.Stop();
        return (sw.Elapsed.TotalMilliseconds / times, result);
    }

    public record TimeResult(double TimeMs, double Result);

    private static TimeResult TimeAndResult2(Func<double> executeAlgorithm, int times) {
        var sw = Stopwatch.StartNew();
        double result = 0;
        
        for (var i = 0; i < times; ++i) {
            result = executeAlgorithm();
        }
        
        sw.Stop();
        return new TimeResult(sw.Elapsed.TotalMilliseconds / times, result);
    }


    // Time O(n)    space O(1)
    private static double StandardDeviation1(int[] numbers) {
        var total = 0.0;
        var count = 0;
        foreach (var number in numbers) {
            total += number;
            count += 1;
        }

        var avg = total / count;
        var sumSquaredDifferences = 0.0;
        foreach (var number in numbers) {
            sumSquaredDifferences += Math.Pow(number - avg, 2);
        }

        var variance = sumSquaredDifferences / count;
        return Math.Sqrt(variance);
    }

    // Time O(n²)    space O(1)
    private static double StandardDeviation2(int[] numbers) {
        var sumSquaredDifferences = 0.0;
        var countNumbers = 0;
        foreach (var number in numbers) {
            var total = 0;
            var count = 0;
            foreach (var value in numbers) {
                total += value;
                count += 1;
            }

            var avg = total / count;
            sumSquaredDifferences += Math.Pow(number - avg, 2);
            countNumbers += 1;
        }

        var variance = sumSquaredDifferences / countNumbers;
        return Math.Sqrt(variance);
    }

    // Time O(n)    space O(1)  best legibility to calculate avg
    private static double StandardDeviation3(int[] numbers) {
        var count = numbers.Length;
        var avg = (double)numbers.Sum() / count;
        var sumSquaredDifferences = 0.0;
        foreach (var number in numbers) {
            sumSquaredDifferences += Math.Pow(number - avg, 2);
        }

        var variance = sumSquaredDifferences / count;
        return Math.Sqrt(variance);
    }
}