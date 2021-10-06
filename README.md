# About

This project is a Price Checker System that reads a code and retrieves the corresponding product from a MySQL database.
An instance of MySQL must be running on your computer with the imported database (not included) to be able to use this system successfully. You can use it without the database, but you won't be able to reach the "retrieved" state.

The implementation I chose is inspired from state machines. As it's done on the same window, I defined states as Actions (which have no output, but can have input), and put them in a dictionary to change states in code when needed. Said states will change the layout and contents of the Form Elements when possible.

With this implementation, I aimed to give the code an understandable and clean structure; I aimed to avoid repeating lines of code too.

--

# Acerca de

Este proyecto es un Sistema Verificador de Precios que lee un código y recupera el producto correspondiente de una base de datos MySQL.
Es necesario ejecutar una instancia de MySQL e importar la base de datos (no incluida) para poder usar este sistema exitosamente. Puede utilizarse sin la base de datos, pero no podrá alcanzar el estado "retrieved".

La implementación está inspirada en Máquinas de Estados. Como debe realizarse todo en una sola ventana, definí los estados como Acciones (los cuales pueden NO tener salida, pero sí tener entrada, que en este caso no fue necesario), y coloqué dichos estados en un diccionario para cambiar entre ellos en el código cuando sea necesario. Dichos estados cambiarán el diseño y el contenido de los Elementos del Form cuando sea posible.

Con esta implementación intenté darle una estructura comprensible y limpia al código, así como evitar repetir líneas de código.
