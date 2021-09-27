clear
salir=1 
if [[ $EUID -ne 0 ]]; then
	echo "El script debe ser ejecutado como usuario root"
	salir=0
fi
while [ $salir -eq 1 ]
do
	echo Gestor de Usuarios 
	echo " "
	echo 1-Agregar usuario con directorio incluido
	echo 2-Eliminar Usuario 
	echo 3-Gestionar Contraseña 
	echo 4-Crear Grupo
	echo 5-Eliminar Grupo
	echo 6-Agregar usuario a un grupo
	echo 7-Eliminar usuario de un grupo
	echo 8-Salir
	echo " "	
	read -p "Seleccione una opción: " opcion
	case $opcion in 
		1)
		clear 
		echo Agregar usuario 
		echo ""
		read -p "Ingrese nombre: " nom
		useradd $nom 
		echo "El usuario de nombre $nom ha sido ingresado correctamente"
		echo "Su directorio personal es $nom"
		passwd -d $nom 		
		;;
		
		2)
		clear 
		echo Eliminar usuario 		
		read -p "Ingrese nombre de usuario a eliminar: " baja
		userdel $baja 
		echo "$baja ha sido eliminada del sistema"
		;;
		
		3)
		clear 
		echo Gestionar contraseña		 
		echo Crear o cambiar una contraseña 
		read -p "Ingrese nombre de usuario: " usu
		passwd $usu		
		;;

		4)
		clear 
		echo Crear grupo
		read -p "Ingrese nombre de grupo a ingresar: " grupo
		groupadd $grupo
		echo "Se ha añadido $grupo como nuevo grupo"
		;;
		
		5)
		clear
		echo Eliminar grupo
		read -p "Ingrese nombre de grupo a eliminar: " grupoeli
		groupdel $grupoeli
		echo "El grupo $grupoeli ha sido eliminado"
		;;

		6)
		clear 
		echo Agregar usuario a un grupo
		read -p "Ingrese nombre de usuario: "  usugrupo
		read -p "Ingrese grupo al que desea entrar: " grupousu
		gpasswd -a $usugrupo $grupousu 
		echo Usuario agregado correctamente
		;;

		7)
		clear
		echo Eliminar usuario de un grupo 
		read -p "Ingrese nombre del usuario: " usugrupoeli
		read -p "ingrese nombre del grupo: " grupousueli
		gpasswd -d $usugrupoeli $grupousueli 
		echo El usuario ha sido eliminado correctamente 
		;;

		8)
		echo Saliendo
		salir=0
		;;

		*)
		clear
		echo Seleccione una opcion correcta
		;;

	esac

done