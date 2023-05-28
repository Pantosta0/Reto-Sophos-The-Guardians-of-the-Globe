# Reto Sophos "The Guardians of the Globe"
Realizado usando .NET 6
## Estructura
- Las **querys** para poblar la base de datos se encuentran en [/Database Querys](DatabaseQuerys/)
- El **código** de la api se encuentra en [/GuardiansOfTheGlobeAPI](GuardiansOfTheGlobeAPI/)
- La **documentación** se encuentra en [/Documentation](Documentation/)
## ¿Cómo buildear la aplicación?
La aplicación se encuentra **dockerizada**, así que requiere que el servicio de docker o el cliente de [docker desktop](https://www.docker.com/products/docker-desktop/) estén corriendo.
Para desplegar la aplicación nos ubicamos en la carpeta que contiene el archivo `docker-compose.yml` y ejecutamos el siguiente comando:
```docker-compose up```
