# Dotnet Observability Demo

This repository demonstrates how to implement observability in a .NET application using **OpenTelemetry**, **Prometheus**, and **Grafana**. It provides a sample setup for collecting, exporting, and visualizing metrics and traces from a .NET Core web application.

## 🧰 Features

- ✅ .NET 8 Web API with built-in OpenTelemetry instrumentation
- 📊 Prometheus for metrics scraping and storage
- 📈 Grafana for metrics and trace visualization
- 📦 OpenTelemetry Collector for telemetry routing
- 🐳 Docker Compose for easy local orchestration

## 📦 Stack Overview

| Component            | Description                                                  |
|---------------------|--------------------------------------------------------------|
| ASP.NET Core API     | Sample app instrumented with OpenTelemetry                   |
| OpenTelemetry Collector | Middleware to export telemetry data to various backends     |
| Prometheus           | Scrapes metrics exposed by the app and the OTel Collector    |
| Grafana              | Visualizes Prometheus metrics and traces                     |

## 🚀 Getting Started

### 1. Clone the Repository

```bash
git clone https://github.com/mustafaalkan64/Dotnet-Observability-Demo.git
cd Dotnet-Observability-Demo
```
2. Run with Docker Compose
```bash
docker-compose up --build
```

## 🐳 Running the Stack

This will start the following services:

- **dotnet-observability-demo** – ASP.NET Core Web API app
- **otel-collector** – OpenTelemetry Collector
- **prometheus** – Metrics backend
- **grafana** – Dashboard frontend

---

## 🌐 Access the Services

| Service     | URL                           |
|-------------|-------------------------------|
| Web API     | [http://localhost:5000](http://localhost:5000) |
| Prometheus  | [http://localhost:9090](http://localhost:9090) |
| Grafana     | [http://localhost:3000](http://localhost:3000) |

> **Grafana Default Login:**  
> Username: `admin`  
> Password: `admin`

---

## ⚙️ Configuration Files

- `otel-collector-config.yaml` – OTel Collector pipeline configuration
- `prometheus.yml` – Prometheus scraping targets and intervals
- `docker-compose.yml` – Multi-container orchestration setup

---

## 📊 Visualizing Metrics

1. Navigate to [http://localhost:3000](http://localhost:3000)
2. Log in with default credentials: `admin / admin`
3. Add Prometheus as a data source: `http://prometheus:9090`
4. Import or create dashboards to monitor:
   - HTTP request durations
   - Response status counts
   - Trace spans

---

## 🛠️ Customization Tips

- Add new metrics using `Meter` or `ActivitySource` in the .NET app
- Extend OpenTelemetry Collector with exporters like **Jaeger**, **Zipkin**, etc.
- Set up **Grafana alerts** based on custom metric thresholds

---

## 📄 License

This project is licensed under the [MIT License](LICENSE).

