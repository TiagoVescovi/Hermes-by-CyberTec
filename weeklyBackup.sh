mysqldump -u ESI -p BD_CHAT > BackupBD_CHAT.sql
mkdir respaldo
rsync -I BackupBD_CHAT.sql root@ip:/home/UTU/respaldo