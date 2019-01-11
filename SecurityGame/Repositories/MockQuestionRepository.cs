using SecurityGame.Models;
using SecurityGame.Repositories.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace SecurityGame.Repositories
{
    public class MockQuestionRepository : IQuestionRepository
    {
        private List<Question> questions;

        public MockQuestionRepository()
        {
            questions = new List<Question>()
            {
                new Question()
                {
                    ID = 1,
                    Content = "What is the term for computer programs that can wreak havoc on your devices?",
                    CorrectAnswer = "Malware",
                    WrongAnswer = "Damagedroids",
                    CorrectReputationChange = 15,
                    CorrectVirusChange = -10,
                    WrongReputationChange = -15,
                    WrongVirusChange = 5
                },
                new Question()
                {
                    ID = 2,
                    Content = "What is spyware?",
                    CorrectAnswer = "Software that collects data from your computer.",
                    WrongAnswer = "The clothing James Bond wears.",
                    CorrectReputationChange = 10,
                    CorrectVirusChange = -10,
                    WrongReputationChange = -10,
                    WrongVirusChange = 10
                },
                new Question()
                {
                    ID = 3,
                    Content = "Which of these is an example of a phishing email?",
                    CorrectAnswer = "You have won the lottery! Follow this link to claim!",
                    WrongAnswer = "FacePage - You have a new message.",
                    CorrectReputationChange = 16,
                    CorrectVirusChange = -5,
                    WrongReputationChange = -16,
                    WrongVirusChange = 5
                },
                new Question()
                {
                    ID = 4,
                    Content = "When do you need to use anti-virus software?",
                    CorrectAnswer = "All the time, on all web-connected devices - and make sure it's regularly updated.",
                    WrongAnswer = "When you first buy a computer.",
                    CorrectReputationChange = 25,
                    CorrectVirusChange = -3,
                    WrongReputationChange = -30,
                    WrongVirusChange = 20
                },
                new Question()
                {
                    ID = 5,
                    Content = "When do you need to use anti-virus software?",
                    CorrectAnswer = "All the time, on all web-connected devices - and make sure it's regularly updated.",
                    WrongAnswer = "When you first buy a computer.",
                    CorrectReputationChange = 14,
                    CorrectVirusChange = -20,
                    WrongReputationChange = -30,
                    WrongVirusChange = 20
                },
                new Question()
                {
                    ID = 6,
                    Content = "Which of these is an indicator that a website is secure?",
                    CorrectAnswer = "The web address starts with https://",
                    WrongAnswer = "The URL includes the company name and the webpage shows the company logo.",
                    CorrectReputationChange = 10,
                    CorrectVirusChange = -17,
                    WrongReputationChange = -13,
                    WrongVirusChange = 12
                },
                new Question()
                {
                    ID = 7,
                    Content = "What is the best password policy?",
                    CorrectAnswer = "Never use the 'remember password' prompt and have different complex passwords for each account.",
                    WrongAnswer = "Something personal, like your pet's name or your date of birth.",
                    CorrectReputationChange = 21,
                    CorrectVirusChange = -14,
                    WrongReputationChange = -13,
                    WrongVirusChange = 21
                },
                new Question()
                {
                    ID = 8,
                    Content = "When do you need to use anti-virus software?",
                    CorrectAnswer = "All the time, on all web-connected devices - and make sure it's regularly updated.",
                    WrongAnswer = "When you first buy a computer.",
                    CorrectReputationChange = 1,
                    CorrectVirusChange = -7,
                    WrongReputationChange = -3,
                    WrongVirusChange = 2
                },
                new Question()
                {
                    ID = 9,
                    Content = "Which of these is the least risky to talk about on social media?",
                    CorrectAnswer = "What you had for your quiet Sunday lunch at home.",
                    WrongAnswer = "Your new phone number.",
                    CorrectReputationChange = 12,
                    CorrectVirusChange = -9,
                    WrongReputationChange = -6,
                    WrongVirusChange = 3
                },
            };
        }

        public IEnumerable<Question> GetAllQuestions()
            => questions;

        public Question GetQuestion(int id)
            => questions.Where(q => q.ID == id).FirstOrDefault();

        public void SaveQuestion(Question question)
        {
            if (!questions.Contains(question))
                questions.Add(question);
        }

        public void AddQuestion(Question question)
            => questions.Add(question);

        public void DeleteQuestion(Question question)
            => questions.Remove(question);
    }
}
