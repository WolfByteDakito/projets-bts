using System;
using System.Linq; // Pour utiliser .Contains() et .ToArray()

public class GuessTheWord
{
    public static void Main(string[] args)
    {
        Console.WriteLine("--- Jeu : Devinez le Mot ---");

        // --- Étape 1 : Le premier utilisateur entre un mot ---
        string wordToGuess;
        while (true)
        {
            Console.Write("Joueur 1 : Veuillez entrer le mot à deviner (uniquement des lettres) : ");
            wordToGuess = Console.ReadLine().ToUpper(); // Convertir en majuscules pour faciliter la comparaison
            if (!string.IsNullOrWhiteSpace(wordToGuess) && wordToGuess.All(char.IsLetter))
            {
                break;
            }
            Console.WriteLine("Entrée invalide. Veuillez entrer un mot composé uniquement de lettres.");
        }

        Console.Clear(); // Effacer la console pour cacher le mot au Joueur 2
        Console.WriteLine("Le mot a été enregistré. Au tour du Joueur 2 de deviner !");

        // Initialiser l'affichage du mot (ex: H_L_O)
        char[] guessedWordDisplay = new char[wordToGuess.Length];
        for (int i = 0; i < wordToGuess.Length; i++)
        {
            guessedWordDisplay[i] = '_';
        }

        int maxAttempts = 10; // Nombre d'essais autorisé
        int attemptsMade = 0;
        bool wordGuessed = false;
        string guessedLetters = ""; // Pour garder une trace des lettres déjà tentées

        // --- Étape 2 : Le second utilisateur devine le mot ---
        while (attemptsMade < maxAttempts && !wordGuessed)
        {
            Console.WriteLine($"\nMot à deviner : {string.Join(" ", guessedWordDisplay)}");
            Console.WriteLine($"Lettres déjà devinées : {guessedLetters}");
            Console.WriteLine($"Essais restants : {maxAttempts - attemptsMade}");

            Console.Write("Joueur 2 : Entrez une lettre pour deviner : ");
            string guessInput = Console.ReadLine().ToUpper();

            if (string.IsNullOrWhiteSpace(guessInput) || guessInput.Length != 1 || !char.IsLetter(guessInput[0]))
            {
                Console.WriteLine("Entrée invalide. Veuillez entrer une seule lettre.");
                continue;
            }

            char currentGuess = guessInput[0];

            if (guessedLetters.Contains(currentGuess))
            {
                Console.WriteLine($"Vous avez déjà essayé la lettre '{currentGuess}'.");
                continue;
            }

            guessedLetters += currentGuess; // Ajouter la lettre aux lettres déjà devinées
            attemptsMade++; // Incrémenter le nombre d'essais

            bool letterFound = false;
            for (int i = 0; i < wordToGuess.Length; i++)
            {
                if (wordToGuess[i] == currentGuess)
                {
                    guessedWordDisplay[i] = currentGuess;
                    letterFound = true;
                }
            }

            if (letterFound)
            {
                Console.WriteLine($"Bonne pioche ! La lettre '{currentGuess}' est dans le mot.");
            }
            else
            {
                Console.WriteLine($"Désolé, la lettre '{currentGuess}' n'est pas dans le mot.");
            }

            // Vérifier si le mot a été entièrement deviné
            if (new string(guessedWordDisplay) == wordToGuess)
            {
                wordGuessed = true;
            }
        }

        // --- Fin du jeu ---
        Console.WriteLine("\n--- FIN DU JEU ---");
        if (wordGuessed)
        {
            Console.WriteLine($"Félicitations, Joueur 2 ! Vous avez deviné le mot : {wordToGuess} en {attemptsMade} essais.");
        }
        else
        {
            Console.WriteLine($"Dommage, Joueur 2 ! Vous n'avez pas réussi à deviner le mot. Le mot était : {wordToGuess}");
        }
    }
}
