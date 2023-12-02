
# Hello Quiz!

Ce projet est le premier brief de ma formtion .NET chez Simplon. Il consiste en la création d'un quiz à partir du language C# et utilise un fichier CSV pour stocker et récupérer les questions/réponses possibles/bonne réponses en fonction de leur catégorie.


## Auteurs

- [@EnguerranSGG](https://github.com/EnguerranSGG)

## Déploiment

Pour récupérer ce projet il suffit de cloner le repository et d'utiliser la commande "dotnet run".


## Fonctionnalités

### Main

Elle va acceuillir le joueur, récupérer son nom et le conduire vers la méthode Choice. 

### Choice 

Elle va proposer au joueur les différentes catégories du quiz et tournera en boucle tant que le joueur n'aura pas entré une réponse valide. Elle va ensuite récupérer le choix du joueur et l'utiliser pour lancer un quiz avec son choix de catégorie pour venir filtrer les questions. 

### Quiz

La méthode Quiz commence par une zone qui va venir récupérer les données du CSV et les découper pour qu'elles soient exploitables pour le quiz. À savoir qu'une classe "QuizItem" a été crée en amont pour paramétrer et receuillir les données nécessaires au bon fonctionnement du quiz. 

Elle va ensuite utiliser le choix de catégorie pour venir filter les données exploitables et les insérer dans le template de quiz, ce dernier peut acceuillir n'importe quel nombre de questions vu qu'il fonctionne avec un "for" basé sur le nombre d'élements filtrés par catégorie.

Chaque question va donc ensuite être posé à la suite. Des points et des commentaires seront donnés à chaque réponse du joueur. Une sécurité est ajoutée avec un "do/while" pour s'assurer que le joueur entre une réponse valide. 

## EndGame

Cette métode va finalement venir receuillir le score du joueur puis son nom (récupéré de méthodes en méthodes) pour faire un commentaire en fonction de son pourcentage de bonnes réponses.


## Les étapes de création de mon jeu de quizz :

### Ecrire les questions en "dur" dans le code

Phase prairie au cours de laquelle je vais experimenter un peu l'algorithmie C# et créer simplement une méthode acceuil qui servira à acceuillir le
joueur, demander son nom et le conduire vers une seconde méthode qui lui demandera une catégorie pour son quiz (cette méthode tournera en bloucle
tant que le joueur n'entrera pas une réponse valide).

### Récupérer les questions du fichier CSV et les "découper"

Maintenant que j'ai une base pour mon jeu, il va maintenant falloir s'attaquer aux questions du quiz et donc les récupérer sur le csv. Une fois
récupérer, il conviendra d'abord de découper les données en (questions/réponses possibles/bonne réponses) pour ensuite rédecouper les réponses proposées.

### Injecter les données du CSV dans un premier questionnaire

Maintenant que l'on a bien découpé les données du questionnaire "programmation", on va les injecter dans une méthode "Quiz" qui aura pour but de poser
les questions, proposer les réponses possibles, récupérer les réponses du joueur, les comparer à la bonne réponse, lui dire s'il a eu bon ou non pour
ensuite mettre à jour le score. Le score sera ensuite récupére par la méthode (EndGame). 

### La méthode EndGame

Ici, comme l'indique son nom, on va créer la méthode qui va mettre fin au jeu. L'objectif sera de récupérer le nom du joueur et son score pour lui
annoncer et faire un petit commentaire bien condecsendant en fonction du pourcentage de bonnes réponses. 

### Créer un second Quiz

Ici, le but est d'abord de faire quelque chose de fonctionnel, pas encore besoin d'optimiser le code. On va donc créer de nouvelles questions sur
le CSV et suivre la même méthodologie que précedemment, quitte à copier/coller est modifier en fonction des besoins.

### La gestion des erreurs

À par la phase du choix de questionnaire, on ne s'est pas encore vraiment frotter à la gestion des erreurs, il va donc falloir revenir sur chaque
étapes du questionnaire où l'on demande une réponse au joueur et prévoir les cas où il rentrerait un blanc ou une réponse imprévue. (et en profiter
pour se moquer de lui, évidemment).

### Créer une section aléatoire pour le Quiz

Maintenant que l'on a un quiz "parfaitement fonctionnel" on va pourvoir ajouter un choix de Quiz aléatoire. Le but serait de simplement créer un nombre aléatoire
en fonction du nombre de catégorie disponibles.

### Réfactoring des quiz et système de filtre par catégories

Pour finir, on va créer des catégories dans le fichier CSV et tenter d'avoir une seule méthode pour les trois quiz dans laquelle
on va venir injecter les données filtrées du CSV en se basant sur les catégorie nouvellement crées. 