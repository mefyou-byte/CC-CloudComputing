# CC-CloudComputing


# Observability 
Observability in Azure ermöglicht die Überwachung der internen Zustände eines Systems durch das Sammeln und Analysieren von Daten aus verschiedenen Quellen. 
Mit anderen Worten, es geht darum, zu sehen, was innerhalb Ihres Systems zu jedem Zeitpunkt geschieht, auch wenn es sich über mehrere Umgebungen verteilt.

Azure bietet mehrere Tools und Services zur Unterstützung der Observability, darunter:



Azure Application Insights: Ein Dienst, der detaillierte Telemetrie- und Diagnosedaten zu Ihrer Anwendung bereitstellt, einschließlich 
Leistungsmetriken, Ausnahmeverfolgung und Anforderungsverfolgung.

Azure Log Analytics: Ein Dienst, mit dem Sie Log- und Leistungsdaten aus einer Vielzahl von Quellen, einschließlich Azure-Ressourcen und
Drittanbieteranwendungen, sammeln, analysieren und visualisieren können.

Azure Service Health: Ein Dienst, der aktuelle Informationen über den Zustand von Azure-Diensten in Ihrer Region bereitstellt.

Um die Observability in Azure aufrechtzuerhalten, sind einige bewährte Methoden zu beachten. Hierzu gehören die Implementierung
von Überwachungs- und Protokollierungsmechanismen in Anwendungen und Infrastruktur, die Verwendung von Diagnose- und Analysetools und die Einhaltung
bewährter Methoden für die Entwicklung und Bereitstellung von Anwendungen und Diensten.


Azure Monitor: Ein zentralisierter Überwachungsdienst, der Echtzeit-Sichtbarkeit in die 
Leistung und Gesundheit Ihrer Anwendungen und Infrastruktur bietet.

Hier ein Beispiel wie Azure Monitoring eingesetzt werden kann: 

1.) Azure Monitor über eine ressourcengruppe erstellen -> diese kann zum Beispiel eine VM oder Datenbank sein. In diesem Fall ist es eine Azure Cosmos DB.

Dadurch kann ein Monitoring über die CosmosDB erfolgen: 
![image](https://user-images.githubusercontent.com/74449850/225974841-fef121d4-766d-4027-91fc-9ae7c7aac35a.png)

Zudem können verschiedene Metriken ausgewählt werden: 
 ![image](https://user-images.githubusercontent.com/74449850/225974952-6076be83-aa2c-4875-bf22-e3189d605a57.png)
