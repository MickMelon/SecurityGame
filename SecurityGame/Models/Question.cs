namespace SecurityGame.Models
{
    public class Question
    {
        public int ID { get; set; }
        public string Content { get; set; }
        public string CorrectAnswer { get; set; }
        public string WrongAnswer { get; set; }
        public int CorrectVirusChange { get; set; }
        public int CorrectReputationChange { get; set; }
        public int WrongVirusChange { get; set; }
        public int WrongReputationChange { get; set; }
    }
}
