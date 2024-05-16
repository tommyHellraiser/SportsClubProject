# SportsClubProject
## Detalles de uso
Para correr la aplicacion, se debe tener una instancia de MySql corriendo en el sistema como precondicion.

Una vez este corriendo la instancia, puede presionar play en el debugger de la solucion y la aplicacion construira 
automaticamente la base de datos con los datos iniciales

Si desea cambiar el nombre de la base de datos que se creara, modifique el campo "Database" dentro de Config/config.json.
Por defecto, la base de datos que se creara se llama "SportsClub"

La base de datos se reseteara solamente la primera vez que se corra, las proximas no se ejecutara este proceso

Para volver a reiniciar la base, puede configurar "ResetDatabase" en true en Config/config.json

## Aclaraciones extra
- Los archivos de la base de datos y su schema estan dentro de la carpeta MySql

## Usuarios disponibles
- Username: "paganeitor"; Pass: "123456"
- Username: "mlopez"; Pass: "22112211"
- Username: "tommy"; Pass: "000000"