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
        int nbQuestions = 0;

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

        Console.WriteLine("Le quiz sur la programmation donc? Très bien !");
        Console.WriteLine("\n");
        Console.WriteLine(questionsProg[0]);
        nbQuestions++;
        Console.WriteLine("\n");
        Console.WriteLine($"Tape 1 pour " + questions1Prog[0] + ", 2 pour " + questions1Prog[1] + " et 3 pour " + questions1Prog[2] + ".");
        Console.WriteLine("\n");

        var reponse1Prog = Console.ReadLine();

        if (reponse1Prog == answersProg[0])
        {
            score += 1;
            Console.WriteLine("\n");
            Console.WriteLine("Pas mal !");
            Console.WriteLine($"Score : " + score + "/4.");
        }
        else
        {
            Console.WriteLine("\n");
            Console.WriteLine("Mouais...");
        }

        Console.WriteLine("\n");
        Console.WriteLine(questionsProg[1]);
        nbQuestions++;
        Console.WriteLine("\n");
        Console.WriteLine($"Tape 1 pour " + questions2Prog[0] + ", 2 pour " + questions2Prog[1] + " et 3 pour " + questions2Prog[2] + ".");
        Console.WriteLine("\n");

        var reponse2Prog = Console.ReadLine();

        if (reponse2Prog == answersProg[1])
        {
            score += 1;
            Console.WriteLine("\n");
            Console.WriteLine("Pas mal !");
            Console.WriteLine($"Score : " + score + "/4.");
        }
        else
        {
            Console.WriteLine("\n");
            Console.WriteLine("Mouais...");
        }

        Console.WriteLine("\n");
        Console.WriteLine(questionsProg[2]);
        nbQuestions++;
        Console.WriteLine("\n");
        Console.WriteLine($"Tape 1 pour " + questions3Prog[0] + ", 2 pour " + questions3Prog[1] + " et 3 pour " + questions3Prog[2] + ".");
        Console.WriteLine("\n");

        var reponse3Prog = Console.ReadLine();

        if (reponse3Prog == answersProg[2])
        {
            score += 1;
            Console.WriteLine("\n");
            Console.WriteLine("Pas mal !");
            Console.WriteLine($"Score : " + score + "/4.");
        }
        else
        {
            Console.WriteLine("\n");
            Console.WriteLine("Mouais...");
        }

        Console.WriteLine("\n");
        Console.WriteLine(questionsProg[3]);
        nbQuestions++;
        Console.WriteLine("\n");
        Console.WriteLine($"Tape 1 pour " + questions4Prog[0] + ", 2 pour " + questions4Prog[1] + " et 3 pour " + questions4Prog[2] + ".");
        Console.WriteLine("\n");

        var reponse4Prog = Console.ReadLine();

        if (reponse4Prog == answersProg[3])
        {
            score += 1;
            Console.WriteLine("\n");
            Console.WriteLine("Pas mal !");
            Console.WriteLine($"Score : " + score + "/4.");
        }
        else
        {
            Console.WriteLine("\n");
            Console.WriteLine("Mouais...");
        }

        EndGame(score, nbQuestions);
    }

    static public void SecondQuiz()
    {
        var (questionsFlim, choicesFlim, answersFlim) = SecondQuestionsData();
        var (questions1Flim, questions2Flim, questions3Flim, questions4Flim) = SecondQuizQuestions();
        int score = 0;
        int nbQuestions = 0;

        Console.WriteLine("Le quiz sur la programmation donc? Très bien !");
        Console.WriteLine("\n");
        Console.WriteLine(questionsFlim[0]);
        nbQuestions ++;
        Console.WriteLine("\n");
        Console.WriteLine($"Tape 1 pour " + questions1Flim[0] + ", 2 pour " + questions1Flim[1] + " et 3 pour " + questions1Flim[2] + ".");
        Console.WriteLine("\n");

        var reponse1Flim = Console.ReadLine();

        if (reponse1Flim == answersFlim[0])
        {
            score += 1;
            Console.WriteLine("\n");
            Console.WriteLine("Pas mal !");
            Console.WriteLine($"Score : " + score + "/4.");
        }
        else
        {
            Console.WriteLine("\n");
            Console.WriteLine("Mouais...");
        }

        Console.WriteLine("\n");
        Console.WriteLine(questionsFlim[1]);
        nbQuestions++;
        Console.WriteLine("\n");
        Console.WriteLine($"Tape 1 pour " + questions2Flim[0] + ", 2 pour " + questions2Flim[1] + " et 3 pour " + questions2Flim[2] + ".");
        Console.WriteLine("\n");

        var reponse2Flim = Console.ReadLine();

        if (reponse2Flim == answersFlim[1])
        {
            score += 1;
            Console.WriteLine("\n");
            Console.WriteLine("Pas mal !");
            Console.WriteLine($"Score : " + score + "/4.");
        }
        else
        {
            Console.WriteLine("\n");
            Console.WriteLine("Mouais...");
        }

        Console.WriteLine("\n");
        Console.WriteLine(questionsFlim[2]);
        nbQuestions++;
        Console.WriteLine("\n");
        Console.WriteLine($"Tape 1 pour " + questions3Flim[0] + ", 2 pour " + questions3Flim[1] + " et 3 pour " + questions3Flim[2] + ".");
        Console.WriteLine("\n");

        var reponse3Flim = Console.ReadLine();

        if (reponse3Flim == answersFlim[2])
        {
            score += 1;
            Console.WriteLine("\n");
            Console.WriteLine("Pas mal !");
            Console.WriteLine($"Score : " + score + "/4.");
        }
        else
        {
            Console.WriteLine("\n");
            Console.WriteLine("Mouais...");
        }

        Console.WriteLine("\n");
        Console.WriteLine(questionsFlim[3]);
        nbQuestions++;
        Console.WriteLine("\n");
        Console.WriteLine($"Tape 1 pour " + questions4Flim[0] + ", 2 pour " + questions4Flim[1] + " et 3 pour " + questions4Flim[2] + ".");
        Console.WriteLine("\n");

        var reponse4Flim = Console.ReadLine();

        if (reponse4Flim == answersFlim[3])
        {
            score += 1;
            Console.WriteLine("\n");
            Console.WriteLine("Pas mal !");
            Console.WriteLine($"Score : " + score + "/4.");
        }
        else
        {
            Console.WriteLine("\n");
            Console.WriteLine("Mouais...");
        }

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




