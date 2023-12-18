
# Projet GESAMM

Bienvenue sur le guide d'utilisation de l'application GESAMM afin d'avoir toutes les prédispositions pour pouvoir utiliser l'application correctement.


## Auteurs

- [INAN Sami](https://github.com/C4SAM)
- [PORQUET Rémi](https://github.com/DevloCore)
- [FERRE Arthur](https://github.com/Sangoffy)


## Licence

Projet reservé à le laboratoire GSB. Il est autorisée à utiliser cette application web dans le cadre de son activité commerciale.


## Prérequis

 Afin de pouvoir utiliser l'application, vous devez, avant cela, installer les logiciels ci-dessous de sorte à pouvoir utiliser le projet :
 - [Sql Server Management Studio (SSMS)](https://learn.microsoft.com/fr-fr/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver16#download-ssms)
 - [Visual Studio (Windows Form)](https://visualstudio.microsoft.com/fr/)

#### Informations supplémentaire :
 - Version Sql Server : 19.1
 - Version Visual Studio : 2022




## Deploiement

To utiliser ce projet

    
1. 
    Clonez le projet sur votre machine, nous conseillons le logiciel GitKraken. Voici le lien du repertoire :  
    https://github.com/DevloCore/GESAMM. 
    
    Vous pouvez également utiliser la commande git comme ci-dessous : git clone https://github.com/DevloCore/GESAMM

2. 
    Dirigez-vous dans le dossier du projet : cd /GESAMM


3. 
    Créer la base de données Cette étape est obligatoire et sert à créer la base de données dans laquelle les données de l'application seront stockées.

4. 
    Importez le fichier "FichierBDD.sql" qui aura pour rôle de remplir la base de données GESAMM avec toutes les données nécessaires à son fonctionnement.

#### A présent, vous pouvez lancer votre application sur Visual Studio sans encombres ou problèmes si vous avez suivi les étapes précédentes.

 
## Utilisateur

Afin de pouvoir accéder au menu de l'application, vous devez vous connecter avec le compte administrateur renseigné dans la base de données :
    
    - Nom d'utilisateur : admin  

    - Mot de passe : leprof
## Fonctionnalités

En tant qu'utilisateur de l'application et membre du laboratoire GSB, vous pouvez accéder aux interfaces suivantes : 

- Interface de connexion

- Menu de l'application

- Consulter les médicaments et ceux en cours de validation

- Ajouter un médicament dans la base de données

- Voir la dernière étape validée d'un médicament et ajouter une étape

- Liste des familles de médicaments et des médicaments d'une famille sélectionnée

- Liste des étapes du workflow d'un médicament choisi

- Liste des normes des étapes et mise à jour de la norme d'une étape.
## Technologies

Languages de programmations : C# et MySQL

Applications utilisées : Sql Server (SSMS) et Visual Studio

Maquettes réalisées à l'aide du site web Figma

