#pragma once
class Calcul
{
private:
	int nbr1;
	int nbr2;

public :
	int additionner(int nbr1, int nbr2);;
	int soustraire(int nbr1, int nbr2);
	int multiplier(int nbr1, int nbr2);
	int diviser(int nbr1, int nbr2);

	int convertion_binaire(int nbr1);
	int convertion_hexa(int nbr1);
	int convertion_decimal(int nbr1);


};

