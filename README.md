# **Guía de programación** 
## **Consideraciones principales**
- 	Siga los principios básicos de desarrollo de software KISS, YAGNI y DRY 
- 	El idioma en que se escribirá el software debe ser el idioma que mejor maneje su equipo, si todos haban español y no todos hablan ingles, el código debe estar escrito en español
- 	El estilo de escritura a usar es CamelCase
- 	Existen dos tipos de CamelCase
o	UpperCamelCase, la primera letra de cada palabra en mayúscula
o	lowerCamelCase, igual que la anterior pero la primera palabra es toda en minúscula.

### **Nombramiento de objetos**
En esta sección se describe la forma como se deben nombrar generalmente los componentes de la aplicación

**Convenciones generales**

- 	 No use guiones “ -  “ ni guiones bajos “ _ “ para separar las palabras

- 	No use prefijos para la elección de nombres

- 	Utilice nombres que se puedan pronunciar

- 	No use abreviaturas o acrónimos para la elección de nombres

- 	Elija nombres que reflejen su propósito dentro del software



**Convenciones especificas**

**Clases/Interfaces**
•	Los nombres de interfaces deben ir antecedidas de I

•	Los nombres de clase deben ser sustantivos en UpperCamelCase

•	Los nombres de clase deben ser en singular 

**Enumerados**

•	Los enumerados se deben crear en un archivo independiente por cada enumerado
enumerados deben contener su debida descripción


•	Los valores del enumerado deben ser escritos en UpperCamelCase


•	Los nombres de clases para DTOs (Data Transfert Object) deben terminar en Dto.

•	Los objetos de capa de repositorio que heredan de la clase Repositorio<T> deben terminar en Repositorio.


•	Los objetos de capa de repositorio que heredan de la clase DbContext deben terminar en Contexto.

**Métodos**
•	Los nombres de los métodos deben ser verbos en UpperCamelCase 

•	Los nombres de los métodos deben reflejar lo que hacen en su implementación 


•	Los parámetros de los métodos no deben ser superar más de 3 tipos primitivos, si requiere más de 3 parámetros primitivos haga un DTO 


•	Los nombres de los parámetros deben ser en lowerCamelCase


**Variables**
- Los nombres de las variables locales deben se lowerCamelCase 

- Las variables globales deben ser privadas y nombradas lowerCamelCase antecedidas de “_”

- Los valores constantes o “quemados” deben ser creados como constantes globales dentro del archivo a clase que se esté utilizando, si la constante se usa en más de un archivo se debe crear una clase para definir estas constantes.




