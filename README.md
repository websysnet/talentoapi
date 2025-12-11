# TalentoAPI — Sistema de Selección de Talentos Deportivos 🏅🤸‍♂️

**Descripción corta**

TalentoAPI es una API REST construida con .NET 10 para gestionar procesos de detección y selección de talentos deportivos. Permite administrar atletas, entrenadores, planes de entrenamiento, pruebas de selección y realizar cálculos estadísticos avanzados (incluyendo percentiles) para apoyar la toma de decisiones técnicas y de scouting. 🧠📊

**¿Para quién?**
- Federaciones y clubes deportivos que quieren centralizar datos de pruebas y rendimiento.
- Scouts, preparadores físicos y entrenadores que requieren informes objetivos.
- Investigadores y analistas deportivos que necesitan pipelines reproducibles de análisis.

**Características principales 🚀**

- Gestión de atletas (perfil, historial, mediciones físicas y resultados de pruebas). 🧍‍♂️🧍‍♀️
- Gestión de entrenadores y roles (acceso, asignaciones y historiales). 👩‍🏫👨‍🏫
- Creación y asignación de planes de entrenamiento (periodización, ejercicios, cargas). 📅🏋️‍♂️
- Gestión de pruebas de selección (tests físicos, técnicos y psicométricos) con resultados detallados. 🏃‍♀️📋
- Cálculos estadísticos y métricas: medias, desviaciones, z-scores y percentiles por edad/categoría. 📈🔍
- Comparativas y ranking por cohortes (edad, categoría, posición). 🥇📋
- Endpoints RESTful listos para integrarse con frontends o sistemas de BI. 🔗
- Soporte para importación/exportación CSV y reportes PDF (opcional). 📥📤

**Modelos y entidades clave 🧩**

- Atleta: nombre, fecha de nacimiento, categoría, posición, historial médico, medidas antropométricas, pruebas realizadas.
- Entrenador: perfil, especialidad, equipo/club, contacto.
- PlanEntrenamiento: fases, sesiones, objetivos, métricas de carga.
- PruebaSeleccion: tipo de prueba (velocidad, resistencia, salto, técnica), unidad, protocolo, fecha, resultados.
- ResultadoPrueba: valor numérico, unidades, condiciones (viento, superficie), percentil calculado.

**Endpoints (ejemplos) 🔗**

- GET /atletas — listar atletas (ejemplo)
- GET /atletas/{id} — detalle de atleta
- POST /atletas — crear atleta
- PUT /atletas/{id} — actualizar atleta
- GET /pruebas — listar pruebas de selección
- POST /pruebas — registrar resultados de pruebas
- GET /estadisticas/percentiles?prueba={id}&cohorte={cohorte} — obtener percentiles

**Endpoints para Deporte y Entrenador (implementados / previstos) ⚽🏋️**

- Deporte (actualmente mapeado en `Program.cs` sin prefijo `/api`):
  - GET /deportes — listar deportes
  - GET /deportes/{id} — obtener deporte por id
  - POST /deportes — crear un nuevo deporte
  - PUT /deportes/{id} — actualizar un deporte
  - DELETE /deportes/{id} — eliminar un deporte

- Entrenador (controlador presente en el código, no está mapeado automáticamente en `Program.cs`):
  - GET /entrenadores — listar entrenadores
  - GET /entrenadores/{id} — obtener entrenador por id
  - POST /entrenadores — crear entrenador
  - PUT /entrenadores/{id} — actualizar entrenador
  - DELETE /entrenadores/{id} — eliminar entrenador

Nota: `Program.cs` actualmente usa mapeos explícitos (ej. `app.MapGet("/deportes", ...)`) que exponen rutas sin `/api`. Si prefieres rutas con prefijo `/api` o usar controladores MVC estándar, convierte las clases en controladores `ApiController` y registra `builder.Services.AddControllers()` + `app.MapControllers()` en `Program.cs`.

**Cálculos estadísticos y percentiles 📐**

- Z-score: normalización por media y desviación estándar por cohorte.
- Percentil: cálculo basado en distribución empírica o parametrizada por prueba.
- Agrupaciones por edad, sexo, categoría y posición para percentiles comparativos.
- Reportes automáticos: transformaciones de datos para visualización (boxplots, histograma).

**Flujo típico de trabajo 📋**

1. Registrar atleta y entrenador.
2. Crear y asignar plan de entrenamiento.
3. Registrar resultados de pruebas en fechas concretas.
4. Calcular métricas y percentiles para evaluar progreso y comparar con cohortes.
5. Generar reportes y decisiones de selección.

**Ejemplo rápido (cURL) 🧪**

```bash
# Crear atleta
curl -X POST https://tu-api.example.com/api/atletas \
  -H "Authorization: Bearer <TOKEN>" \
  -H "Content-Type: application/json" \
  -d '{"nombre":"Juan Pérez","fechaNacimiento":"2008-05-12","categoria":"U17","posicion":"Delantero"}'

# Registrar resultado de prueba
curl -X POST https://tu-api.example.com/api/pruebas \
  -H "Authorization: Bearer <TOKEN>" \
  -H "Content-Type: application/json" \
  -d '{"atletaId":123,"tipo":"20m_sprint","valor":2.85,"unidad":"s","fecha":"2025-12-01"}'
```

**Despliegue y ejecución 🛠️**

- Requisitos: .NET 10 SDK
- Ejecutar local:

```bash
dotnet build
dotnet run --project talentoapi/talentoapi.csproj
```

- Configuraciones en `appsettings.json` para cadenas de conexión y parámetros de cálculo.

**Buenas prácticas recomendadas ✅**

- Versionar las pruebas y protocolos (para reproducibilidad).
- Mantener cohortes bien definidas antes de calcular percentiles.
- Registrar metadatos de condiciones de prueba (p. ej. viento, superficie).
- Añadir pipelines de ETL para limpiar e imputar datos faltantes antes del análisis.

**Siguientes pasos sugeridos 🔭**

- Añadir pruebas unitarias para cálculos de percentiles y z-scores.
- Documentar los endpoints con OpenAPI / Swagger.
- Implementar control de acceso y auditoría por usuario.

**Contribuir 🤝**

Si quieres contribuir, abre un issue describiendo la mejora o PR con tests y documentación.

**Licencia**

Proyecto abierto — licencia a definir por el equipo.

---

Si quieres, lo añado directamente al repositorio o adapto el tono/longitud. ¿Lo dejo así o quieres más secciones (ej.: ERD, ejemplos de payloads, formato CSV)?