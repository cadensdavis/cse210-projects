public class Entry {

    public DateTime Date { get; set; }
    public string Reponse { get; set; }
    public string Prompt { get; set; }


    public void DisplayEntry() {
        Console.WriteLine($"{Date.ToString("MM/dd/yyyy | hh:mm")} \nPrompt: {Prompt} \n>> {Reponse}");
    }


}