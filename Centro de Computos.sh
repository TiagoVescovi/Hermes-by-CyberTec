clear
salir=1
while [ $salir -eq 1 ]; do
	echo Centro de Computos
	echo " "
	echo 1-ABM-Usuarios
	echo 2-Respaldo
	echo 3-Logs
	echo 4-Salir
	echo " "
	read -p "Seleccione una opción: " opcion
	case $opcion in
	1)
		clear
		sh ./ABM.sh
		;;

	2)
		clear
		salir=1
		while [ $salir -eq 1 ]; do
			echo Selecciona el Tipo de Respaldo
			echo " "
			echo 1-Respaldo Diario
			echo 2-Respaldo Semanal
			echo 3-Salir
			echo " "
			read -p "Seleccione una opción: " opcion
			case $opcion in
			1)
				clear
				sh ./dailyBackup.sh
				;;
			2)
				clear
				sh ./weeklyBackup.sh
				;;
			3)
				echo Saliendo
				salir=0
				;;
			esac
		done
		;;

	3)
		clear
		sh ./logs.sh
		;;
	4)
		echo Saliendo
		salir=0
		;;
	*)
		clear
		echo Seleccione una opcion correcta
		;;
	esac

done
