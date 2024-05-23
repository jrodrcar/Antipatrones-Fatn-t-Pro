# Antipatrones

En este ejemplo, la clase MonolithicProgressCalculator maneja tanto el cálculo del progreso del usuario como la interacción con la base de datos para recuperar actividades del usuario y guardar el progreso calculado. Esto puede resultar en una clase grande y difícil de entender, con múltiples responsabilidades.
Para evitar este antipatrón, sería mejor dividir estas responsabilidades en componentes más pequeños y específicos, como una clase para el cálculo del progreso y otra para la interacción con la base de datos. Esto facilitaría la mantenibilidad y la escalabilidad del sistema.
