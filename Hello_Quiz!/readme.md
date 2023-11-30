# Récupérer le projet

Bienvenue, pour récupérer le projet il suffit de ....

# Lancer le projet 

Pour lancer le projet ...

# Les étapes de mon jeu de quizz :

Pour se faciliter la vie, on a au début une seule catégorie. Chaque titre et sous titre de ce readme.md doit être transformé en méthode.

## Ecrire les questions en "dur" dans le code

Phase prairie au cour de laquelle je vais experimenter un peu l'algorithmie C# et créer simplement une méthode acceuil qui servira à acceuillir le
joueur, demander son nom et le conduire vers une seconde méthode qui lui demandera une catégorie pour son quiz (cette méthode tournera en bloucle
tant que le joueur n'entrera pas une réponse valide).

## Récupérer les questions du fichier CSV et les "découper"

Maintenant que j'ai une base pour mon jeu, ici il va maintenant falloir s'attaquer aux questions du quiz et donc les récupérer sur le csv. Une fois
récupérer, il falloir d'abord découper les données en (questions/réponses/bonne réponse) puis découper les réponses proposées.

## Injecter les données du CSV dans un premier questionnaire

Maintenant que l'on a bien découpé les données du questionnaire "programmation", on va les injecter dans une méthode "Quiz" qui aura pour but de poser
les questions, proposer les réponses possibles, récupérer les réponses du joueur, les comparer à la bonne réponse, lui dire s'il a eu bon ou non pour
ensuite mettre à jour le score. Le score sera ensuite récupére par la méthode (EndGame). 

## La méthode EndGame

Ici, comme l'indique le nom, on va créer la méthode qui va mettre fin au jeu. L'objectif sera de récupérer le nom du joueur et son score pour lui
annoncer et faire un petit commentaire bien condecsendant en fonction de. 

## Créer un second Quiz

Ici, le but est d'abord de faire quelque chose de fonctionnel, pas encore besoin d'optimiser le code. On va donc créer de nouvelles questions sur
le CSV et suivre la même méthodologie que précedemment, quitte à copier/coller est modifier en fonction des besoins.

## La gestion des erreurs

À par la phase du choix de questionnaire, on ne s'est pas encore vraiment frotter à la gestion des erreurs, il va donc falloir revenir sur chaque
étapes du questionnaire où l'on demande une réponse au joueur et prévoir les cas où il rentrerait un blanc ou une réponse imprévue. (et en profiter
pour se moquer de lui, évidemment).

## Créer une section aléatoire pour le Quiz 

## Parcourir les questions (boucle)
Pour chacune d'entre elles
1. **Poser la question**

2. **Donner les réponses possibles**

3. **Vérifier si la réponse est bonne/mauvaise/une erreur**

4. **Informer l'utilisateur du résultat et afficher son score**

5. **Boucler**

## Afficher un message d'au revoir avec le score lorsque l'ensemble des questions ont été posées