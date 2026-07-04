Algoritmo VentaImpresores
	Definir cantidad, opcion_pago Como Entero
	Definir precio_sin_iva, precio_con_iva, total_sin_desc, descuento, total_pagar, porc_desc Como Real
	Definir forma_pago Como Cadena
	precio_sin_iva <- 650.00
	precio_con_iva <- precio_sin_iva*1.12
	porc_desc <- 0
	forma_pago <- ''
	Escribir '--- SISTEMA DE VENTAS DE IMPRESORES ---'
	Escribir 'Cantidad de impresoras a comprar:'
	Leer cantidad
	Escribir '    * Menu'
	Escribir '    **********************************************'
	Escribir '    * Seleccione la forma de pago:              *'
	Escribir '    * 1. Efectivo (10% desc)                    *'
	Escribir '    * 2. Tarjeta de credito (5% desc)           *'
	Escribir '    * 3. Vale de regalo (15% desc)              *'
	Escribir '    **********************************************'
	Leer opcion_pago
	Según opcion_pago Hacer
		1:
			porc_desc <- 0.10
			forma_pago <- 'Efectivo'
		2:
			porc_desc <- 0.05
			forma_pago <- 'Tarjeta de credito'
		3:
			porc_desc <- 0.15
			forma_pago <- 'Vale de regalo'
		De Otro Modo:
			porc_desc <- 0
			forma_pago <- 'No valida (Sin descuento)'
	FinSegún
	total_sin_desc <- precio_con_iva*cantidad
	descuento <- total_sin_desc*porc_desc
	total_pagar <- total_sin_desc-descuento
	Escribir '========================================'
	Escribir '           Detalles de Pago'
	Escribir '========================================'
	Escribir 'Cantidad comprada:          ', cantidad
	Escribir 'Precio unitario (con IVA):  Q', precio_con_iva
	Escribir 'Total sin descuento:        Q', total_sin_desc
	Escribir 'Forma de pago elegida:      ', forma_pago
	Escribir 'Descuento realizado:       -Q', descuento
	Escribir '----------------------------------------'
	Escribir 'TOTAL A PAGAR:              Q', total_pagar
	Escribir '========================================'
FinAlgoritmo
