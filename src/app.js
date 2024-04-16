import express from "express";
import { port } from "./server.js";
import { updatesRoutes, updatesRoutes2 } from "../routes/updates.js";
import MainLayouts from "express-ejs-layouts";

const app = express();

// Middleware für das Parsen von URL-kodierten und JSON-Daten
app.use(express.urlencoded({ extended: true }));
app.use(express.json());

// Statische Dateien
app.use(express.static("views/public"));

// Template Engine
app.set("view engine", "ejs");

// Routen
app.get("/update", (req, res) => {
  res.render("main/update.ejs", {
    title: "GreenFinder Updates Input",
  });
});

app.use("/apicall", updatesRoutes2);

app.get("/", (req, res) => {
  res.render("main/login.ejs", {
    title: "GreenFinder Updates Input",
  });
});

// Error-Handling-Middleware
app.use((req, res, next) => {
  res.render("main/404.ejs");
});

// Server starten
app.listen(port, () => {
  console.log("Server ist gestartet");
});
