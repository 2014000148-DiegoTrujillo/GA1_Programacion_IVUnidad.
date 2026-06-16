Algoritmo Lecc16_Act2_Inc1
	Escribir "Diego Trujillo"
	Escribir "IVC"
	Escribir "Clave 31"
	Dimensionar edadesPersonas[7]
	
	Definir ind, cM Como Entero
	cM =0
	
	Para ind=1 Hasta 7  Hacer
		Escribir "Ingrese la edad de la persona",ind, ": "
		leer edadesPersonas[ind]
		Si edadesPersonas[ind]>= 10 Entonces
			cM = cM+1
		Fin Si
	Fin Para
	
	Escribir "Cantidad de personas mayores de edad: ",cM
FinAlgoritmo
