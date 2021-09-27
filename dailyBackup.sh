mysqldump -u ESI -p BD_CHAT > dailyBackupBD_CHAT.sql
fecha = $(date)
mkdir $fecha
rsync dailyBackupBD_CHAT.sql root@.x.x.x.x:/home/UTU/$fecha

