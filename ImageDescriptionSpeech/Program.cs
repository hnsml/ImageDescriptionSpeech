

namespace ImageDescriptionSpeech;

internal class Program
{
    static async Task Main(string[] args)
    {
        Console.Write("Enter the path to the image: ");
        string imagePath = Console.ReadLine();
        Console.WriteLine("Analysis...");
        Console.WriteLine();

        var text = await AzureVisionAnalyzer.AnalyzeImage(imagePath);
        Console.WriteLine(text);

        Console.WriteLine();
        Console.WriteLine("Voicing...");
        var textToSpeech = new TextToSpeech();
        await textToSpeech.SpeakAsync(text);
    }
}
