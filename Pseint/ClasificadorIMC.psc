Algoritmo ClasificadorIMC
    Definir peso, altura, imc Como Real
	
    Escribir "Ingrese el peso en kilogramos:"
    Leer peso
    Escribir "Ingrese la altura en metros:"
    Leer altura
	
    imc <- peso / (altura ^ 2)
	
    Si imc < 18.5 Entonces
        Escribir "IMC: ", imc, ". Categoría: bajo peso."
    Sino
        Si imc < 25 Entonces
            Escribir "IMC: ", imc, ". Categoría: normal."
        Sino
            Si imc < 30 Entonces
                Escribir "IMC: ", imc, ". Categoría: sobrepeso."
            Sino
                Escribir "IMC: ", imc, ". Categoría: obesidad."
            FinSi
        FinSi
    FinSi
	
FinAlgoritmo
