using System;
using System.IO;

class Hello_Quiz
{

    static void Main()
    {
        Console.WriteLine("Bienvenue sur Hello Quiz !");
        Console.WriteLine("\n");

        Console.WriteLine("Pour commencer, entre ton nom d'utilisateur :");
        Console.WriteLine("\n");
        var challengerName = Console.ReadLine();
        Console.WriteLine("\n");
        Console.WriteLine($"Bonjour, " + challengerName + "!");
        Console.WriteLine("\n");
        Choice(challengerName);
    }

    static public void Choice(string? challengerName)
    {
        Console.WriteLine("Quelle catégorie comptes-tu choisir ?");
        Console.WriteLine("\n");
        Console.WriteLine("Tapes 1 pour 'Programmation' ou 2 pour 'Répliques de films cultes'.");
        Console.WriteLine("\n");

        var categoryChoice = Console.ReadLine();

        if (categoryChoice == "1")
        {
            FirstQuiz();
        }
        else if (categoryChoice == "2")
        {
            SecondQuiz();
        }
        else
        {
            Console.WriteLine("Si tu arrives à te planter maintenant, ça promet...");
            Console.WriteLine("\n");
            Console.WriteLine($"Aller, " + challengerName + ", on réessaye :");
            Choice(challengerName);
        }
    }

    static public void FirstQuiz()
    {
        var (questionsProg, choicesProg, answersProg) = FirstQuestionsData();
        var (questions1Prog, questions2Prog, questions3Prog, questions4Prog) = FirstQuizQuestions();
        int score = 0;
        int nbQuestions = 0;

        Console.WriteLine("Le quiz sur la programmation donc? Très bien!");
        Console.WriteLine("\n");

        void AskQuestion(string question, string[] choices, string answer)
        {
            Console.WriteLine(question);
            nbQuestions++;
            Console.WriteLine("\n");
            Console.WriteLine($"Tape 1 pour {choices[0]}, 2 pour {choices[1]}, et 3 pour {choices[2]}.");
            Console.WriteLine("\n");

            string userResponse;
            do
            {
                userResponse = Console.ReadLine();
                if (userResponse != "1" && userResponse != "2" && userResponse != "3")
                {
                    Console.WriteLine("Veuillez entrer une réponse valide (1, 2 ou 3).");
                    Console.WriteLine("\n");
                }
            } while (userResponse != "1" && userResponse != "2" && userResponse != "3");

            if (userResponse == answer)
            {
                score += 1;
                Console.WriteLine("\n");
                Console.WriteLine("Pas mal !");
                Console.WriteLine($"Score : {score}/4.");
                Console.WriteLine("\n");
            }
            else
            {
                Console.WriteLine("\n");
                Console.WriteLine("Mouais...");
                Console.WriteLine($"Score : {score}/4.");
                Console.WriteLine("\n");
            }
        }

        AskQuestion(questionsProg[0], questions1Prog, answersProg[0]);
        AskQuestion(questionsProg[1], questions2Prog, answersProg[1]);
        AskQuestion(questionsProg[2], questions3Prog, answersProg[2]);
        AskQuestion(questionsProg[3], questions4Prog, answersProg[3]);

        EndGame(score, nbQuestions);
    }

    static public void SecondQuiz()
    {
        var (questionsFlim, choicesFlim, answersFlim) = SecondQuestionsData();
        var (questions1Flim, questions2Flim, questions3Flim, questions4Flim) = SecondQuizQuestions();
        int score = 0;
        int nbQuestions = 0;

        Console.WriteLine("Le quiz sur les répliques de film ? Très bien !");
        Console.WriteLine("\n");

        void AskQuestion(string question, string[] choices, string answer)
        {
            Console.WriteLine(question);
            nbQuestions++;
            Console.WriteLine("\n");
            Console.WriteLine($"Tape 1 pour {choices[0]}, 2 pour {choices[1]}, et 3 pour {choices[2]}.");
            Console.WriteLine("\n");

            string userResponse;

            do
            {
                userResponse = Console.ReadLine();
                if (userResponse != "1" && userResponse != "2" && userResponse != "3")
                {
                    Console.WriteLine("Veuillez entrer une réponse valide (1, 2 ou 3).");
                    Console.WriteLine("\n");
                }
            } while (userResponse != "1" && userResponse != "2" && userResponse != "3");

            if (userResponse == answer)
            {
                score += 1;
                Console.WriteLine("\n");
                Console.WriteLine("Pas mal !");
                Console.WriteLine($"Score : {score}/4.");
                Console.WriteLine("\n");
            }
            else
            {
                Console.WriteLine("\n");
                Console.WriteLine("Mouais...");
                Console.WriteLine($"Score : {score}/4.");
                Console.WriteLine("\n");
            }
        }
        AskQuestion(questionsFlim[0], questions1Flim, answersFlim[0]);
        AskQuestion(questionsFlim[1], questions2Flim, answersFlim[1]);
        AskQuestion(questionsFlim[2], questions3Flim, answersFlim[2]);
        AskQuestion(questionsFlim[3], questions4Flim, answersFlim[3]);

        EndGame(score, nbQuestions);
    }

    static public void EndGame(int score, int nbQuestions)
    {
        Console.WriteLine("\n");
        Console.WriteLine("Ça y est ! C'est l'heure du verdict !");
        Console.WriteLine("\n");

        double percentage = (double)score / nbQuestions * 100;

        if (percentage == 100)
        {
            Console.WriteLine("100%?! Mouais, ça se defend...");
        }
        if (percentage >= 75 && percentage < 100)
        {
            Console.WriteLine($"" + percentage + "%? Pas loins du tout ça ! Dommage...");
        }
        if (percentage > 50 && percentage < 75)
        {
            Console.WriteLine($"" + percentage + "%? Pas fou fou mais on va dire que ça passe...");
        }
        if (percentage == 50)
        {
            Console.WriteLine($"" + percentage + "%? C'est bien ça ? Être dans la moyenne ?");
        }
        if (percentage < 50 && percentage > 25)
        {
            Console.WriteLine($"" + percentage + "%? Même pas la moyenne ! HAHA !");
        }
        if (percentage <= 25)
        {
            Console.WriteLine("Eeeeeeeet... vous savez quoi ? Je pense que vous devriez arrêter d'essayer de faire des trucs !");
        }
    }


    static public (List<string>, List<string>, List<string>) FirstQuestionsData()
    {
        string filePath = @"/Users/enguerransmagghe/Projects/Hello_Quiz!/Hello_Quiz!/questions.csv";
        string[] rawData = System.IO.File.ReadAllLines(filePath);

        var questionsProg = new List<string>();
        var choicesProg = new List<string>();
        var answersProg = new List<string>();

        for (int i = 0; i <= 3; i++)
        {
            string[] rawQuestions = rawData[i].Split(';');

            questionsProg.Add(rawQuestions[0]);
            choicesProg.Add(rawQuestions[1]);
            answersProg.Add(rawQuestions[2]);
        }

        return (questionsProg, choicesProg, answersProg);

    }

    static public (List<string>, List<string>, List<string>) SecondQuestionsData()
    {
        string filePath = @"/Users/enguerransmagghe/Projects/Hello_Quiz!/Hello_Quiz!/questions.csv";
        string[] rawData = System.IO.File.ReadAllLines(filePath);

        var questionsFlim = new List<string>();
        var choicesFlim = new List<string>();
        var answersFlim = new List<string>();

        for (int i = 5; i <= 8; i++)
        {
            string[] rawQuestions = rawData[i].Split(';');

            questionsFlim.Add(rawQuestions[0]);
            choicesFlim.Add(rawQuestions[1]);
            answersFlim.Add(rawQuestions[2]);
        }

        return (questionsFlim, choicesFlim, answersFlim);

    }

    static public (string[], string[], string[], string[]) FirstQuizQuestions()
    {
        var (questionsProg, choicesProg, answersProg) = FirstQuestionsData();
        string[] questions1Prog = choicesProg[0].Split('/');
        string[] questions2Prog = choicesProg[1].Split('/');
        string[] questions3Prog = choicesProg[2].Split('/');
        string[] questions4Prog = choicesProg[3].Split('/');

        return (questions1Prog, questions2Prog, questions3Prog, questions4Prog);
    }

    static public (string[], string[], string[], string[]) SecondQuizQuestions()
    {
        var (questionsFlim, choicesFlim, answersFlim) = SecondQuestionsData();
        string[] questions1Flim = choicesFlim[0].Split('/');
        string[] questions2Flim = choicesFlim[1].Split('/');
        string[] questions3Flim = choicesFlim[2].Split('/');
        string[] questions4Flim = choicesFlim[3].Split('/');

        return (questions1Flim, questions2Flim, questions3Flim, questions4Flim);
    }
}




