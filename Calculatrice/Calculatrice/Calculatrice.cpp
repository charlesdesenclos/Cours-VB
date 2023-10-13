// Calculatrice.cpp : Ce fichier contient la fonction 'main'. L'exécution du programme commence et se termine à cet endroit.
//
#define _CRT_SECURE_NO_WARNINGS

#include <iostream>
#include "Calcul.h";



int main()
{
    int nbrchoisit;
    int nbr1 = 0;
    int nbr2 = 0;
    int result = 0;

    Calcul calcul;

    printf("\n\n1 : Additioner\n");
    printf("2 : Soustraire\n");
    printf("3 : Multiplier\n");
    printf("4 : Diviser\n\n");
    printf("Choisir le mode de  calcul :\n\n");
    scanf("%d", &nbrchoisit);

    printf("\n\n Entrez le premier nombre :  \n\n");
    scanf("%d", &nbr1);

    printf("\n\n Entrez le deuxieme nombre : \n\n");
    scanf("%d", &nbr2);


    //printf("\n\ndebug %c", nbrchoisit);
    if (nbrchoisit == 1)
    {
        result = calcul.additionner(nbr1, nbr2);
        printf("Le resultat est : %d", result);
    }
    else if (nbrchoisit == 2)
    {
        result = calcul.soustraire(nbr1, nbr2);
        printf("Le resultat est : %d", result);
    }
    else if (nbrchoisit == 3)
    {
        result = calcul.multiplier(nbr1, nbr2);
        printf("Le resultat est : %d", result);
    }
    else if (nbrchoisit == 4)
    {
        result = calcul.diviser(nbr1, nbr2);
        printf("Le resultat est : %d", result);
    }
    
}


