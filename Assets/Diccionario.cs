using UnityEngine;
using TMPro; // Importa TextMeshPro
using System.Collections.Generic;

public class Diccionario : MonoBehaviour
{
    public TMP_InputField inputField;
    public TMP_Text resultText;

    private Dictionary<string, string> diccionario = new Dictionary<string, string>(System.StringComparer.OrdinalIgnoreCase)
    {
        { "Seguridad laboral", "Conjunto de medidas, políticas y procedimientos destinados a proteger la integridad física y la salud de los trabajadores durante el desempeño de sus tareas." },
        { "Seguridad", "Estado en el que se han identificado, evaluado y controlado los peligros, minimizando la posibilidad de daños a personas, bienes o al entorno." },
        { "Prevención", "Conjunto de acciones planificadas y anticipadas para evitar o reducir la probabilidad de que ocurran accidentes laborales o enfermedades profesionales." },
        { "Riesgo", "Probabilidad de que un trabajador sufra un daño (físico, psíquico o social) como consecuencia de la exposición a un peligro en el entorno de trabajo." },
        { "Riesgos laborales", "Todos aquellos factores o condiciones presentes en el puesto de trabajo que pueden ocasionar accidentes o desencadenar enfermedades profesionales." },
        { "Causa", "Origen o factor determinante que desencadena un accidente o incidente en el ámbito laboral." },
        { "Accidente laboral", "Suceso imprevisto y repentino que ocurre durante el trabajo o como consecuencia del mismo, y que provoca lesión o enfermedad al trabajador." },
        { "Accidente", "Evento no deseado que causa daño o pérdida; en PRL, puede referirse tanto al ámbito laboral como extra-laboral, aunque se insiste en el componente de trabajo para 'accidente laboral'." },
        { "Capacitaciones en seguridad", "Programas de formación y entrenamiento dirigidos a los trabajadores para dotarlos de conocimientos, habilidades y actitudes que les permitan desempeñarse de forma segura." },
        { "Sugerencias", "Propuestas o recomendaciones emitidas por los propios trabajadores o responsables de PRL con el fin de mejorar las condiciones de seguridad y prevención." },
        { "Cultura de prevención", "Conjunto de valores, actitudes y comportamientos compartidos en una organización que priorizan la identificación y control de riesgos como parte de la rutina laboral." },
        { "Normas de seguridad", "Reglas, procedimientos y estándares (internos o reglamentarios) que deben seguirse para garantizar un entorno de trabajo seguro." },
        { "Inspección de Seguridad", "Examen sistemático de las instalaciones, equipos y prácticas de trabajo para verificar el cumplimiento de las normas de seguridad y detectar situaciones de riesgo." },
        { "Campaña de seguridad", "Conjunto de actividades de sensibilización y comunicación –charlas, carteles, vídeos– orientadas a reforzar mensajes de prevención entre los trabajadores." },
        { "Inversión", "Aplicación de recursos económicos para implementar y mantener medidas de prevención, como equipos de protección, formaciones o mejoras en infraestructura." },
        { "Recursos", "Medios humanos, técnicos, materiales y financieros necesarios para desarrollar eficazmente las actividades de prevención de riesgos." },
        { "Patológica", "Empresa donde la seguridad se descuida y los riesgos se ignoran hasta que ocurre un incidente grave." },
        { "Reactiva", "La empresa que responde a los problemas cuando surgen, pero no hay una estrategia sólida de prevención." },
        { "Calculadora", "Empresa donde se cumplen las normas de seguridad, pero más por obligación que por convicción." },
        { "Proactiva", "Empresa la cual, la seguridad es una prioridad, con procesos definidos y un compromiso creciente." },
        { "Generativa", "Empresa con la prevención completamente integrada en la cultura de la empresa, a todos los niveles." }
    };

    public void BuscarPalabra()
    {
        string palabra = inputField.text.ToLower();
        foreach (var entrada in diccionario)
        {
            if (entrada.Key.ToLower() == palabra)
            {
                resultText.text = entrada.Value;
                return;
            }
        }
        resultText.text = "Palabra no encontrada.";
    }
}