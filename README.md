# Feed-The-Animals# Challenge 3 - Feed the Animals 

Este proyecto es una versión avanzada del prototipo para alimentar animales en Unity, donde se corrigieron errores de la plantilla base y se agregaron mecánicas adicionales para volverlo más competitivo.

## 🚀 Mecánicas y Mejoras Implementadas
* **Control del Jugador Completo:** Ahora el personaje se puede mover tanto de forma horizontal como vertical (ejes X y Z) dentro de un rango limitado en la pantalla.
* **Spawns Aleatorios Avanzados:** Los animales (como los perros) aparecen desde la parte superior y también desde los laterales (izquierda y derecha), rotando automáticamente hacia la dirección correcta.
* **Sistema de Puntuación y Vidas:** Se configuró un GameManager que lleva el control de las vidas del jugador y los puntos ganados al alimentar a los animales.
* **Mecánica de Hambre:** Los animales no se destruyen con un solo impacto; requieren ser alimentados varias veces según su tamaño, mostrando su progreso con barras de interfaz (Sliders) sobre ellos.

## 🛠️ Tecnologías Utilizadas
* **Motor:** Unity 6 LTS
* **Lenguaje:** C#
* **Conceptos clave:** Triggers de colisión, instanciación de prefabs con rotación (Quaternion.Euler), interfaz de usuario en espacio de mundo (World Space) y persistencia de datos básica con GameManager.

## 🕹️ Cómo Jugar
1. Usa las flechas del teclado o las teclas `WASD` para mover al jugador en cualquier dirección por el campo.
2. Presiona la **Barra Espaciadora** para lanzar la comida (bananas/proyectiles) y alimentar a los animales antes de que crucen el mapa o te toquen.
