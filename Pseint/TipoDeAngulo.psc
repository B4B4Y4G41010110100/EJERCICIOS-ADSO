Algoritmo TipoDeAngulo
    Definir angulo Como Real
	
    Escribir "Ingrese un ángulo en grados:"
    Leer angulo
	
    Si angulo < 0 O angulo > 180 Entonces
        Escribir "Ángulo inválido."
    Sino
        Si angulo = 90 Entonces
            Escribir "El ángulo es recto."
        Sino
            Si angulo < 90 Entonces
                Escribir "El ángulo es agudo."
            Sino
                Escribir "El ángulo es obtuso."
            FinSi
        FinSi
    FinSi
	
FinAlgoritmo
