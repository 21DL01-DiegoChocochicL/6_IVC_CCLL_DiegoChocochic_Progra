Algoritmo CajeroAutomatico
	Definir pin, PinC, op, intentos como Entero
	Definir saldo, deposito, retiro Como Real
	
	saldo <- 1000
	PinC <- 1234
	intentos <- 0
	
	Escribir "========================================="
	Escribir "       SISTEMA DE CAJERO VIRTUAL         "
	Escribir "========================================="
	
	Mientras intentos < 3 Hacer
		Escribir ""
		Escribir ">> Ingresa tu PIN de seguridad:"
		Leer pin
		
		Si pin == PinC Entonces
			Limpiar Pantalla
			Escribir ""
			Escribir "*****************************************"
			Escribir "    ACCESO CONCEDIDO - BIENVENIDO/A      "
			Escribir "*****************************************"
			
			Repetir
				Escribir ""
				Escribir "---------- MENÚ DE OPERACIONES ----------"
				Escribir "  1. Consultar saldo"
				Escribir "  2. Depositar dinero"
				Escribir "  3. Retirar dinero"
				Escribir "  4. Salir del sistema"
				Escribir "-----------------------------------------"
				Escribir "Seleccione una opción [1-4]:"
				Leer op
				
				Segun op Hacer 
					
					1:
						Escribir ""
						Escribir "--- ESTADO DE CUENTA ---"
						Escribir "Monto Disponible: Q ", saldo
						Escribir "------------------------"
						Limpiar Pantalla
					2:
						Escribir ""
						Escribir "Indique el monto a depositar:"
						Leer deposito
						saldo <- saldo + deposito
						Escribir "¡Operación exitosa!"
						Escribir "Nuevo saldo: Q ", saldo
						Limpiar Pantalla
					3:
						Escribir ""
						Escribir "Indique el monto a retirar:"
						Leer retiro
						Si retiro <= saldo Entonces
							saldo <- saldo - retiro
							Escribir "Retirando efectivo..."
							Escribir "Saldo restante: Q ", saldo
						SiNo
							Escribir "ERROR: Fondos insuficientes."
						FinSi
						Limpiar Pantalla
					4:
						Escribir "Gracias por usasr el cajero"
						Escribir "Cerrando sesión..."
					De Otro Modo:
						Escribir "Opción no válida. Intente de nuevo."
						Limpiar Pantalla
				Fin Segun
			Hasta Que op == 4
			intentos <- 5 
			
		SiNo
			intentos <- intentos + 1
			Escribir "ERROR: PIN incorrecto."
			Escribir "Intento número: ", intentos, " de 3."
			Si intentos < 3 Entonces
				Escribir "Por favor, intente de nuevo."
			FinSi
		Fin Si
	Fin Mientras
	

	Si intentos == 3 Entonces
		Limpiar Pantalla
		Escribir ""
		Escribir "!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!"
		Escribir "   BLOQUEO DE SEGURIDAD ACTIVADO         "
		Escribir "   Demasiados intentos fallidos.         "
		Escribir "!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!"
		Escribir "El sistema se cerrará en 5s..."
		Esperar 5 Segundos
	SiNo
		Escribir ""
		Escribir "========================================="
		Escribir "   GRACIAS POR USAR NUESTROS SERVICIOS   "
		Escribir "========================================="
		Esperar 2 Segundos
		Limpiar Pantalla
	FinSi
	
FinAlgoritmo
