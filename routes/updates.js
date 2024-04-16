import express from 'express';
// import { db } from '../database/db.js';
const updatesController = require('../databaseControllers/updatesController.js');

export let updatesRoutes = express.Router();
export let updatesRoutes2 = express.Router();

updatesRoutes.route("/").get((req, res) => {

}).post((req, res) => {
        console.log("Test" + req.body);
        // res.json("Daten wurden empfangen");
    });

updatesRoutes2.route("/").get(updatesController.getUpdate, (req, res) => {

})

