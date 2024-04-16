import express from 'express';

export let login = express.Router();

login.route("/").get((req, res) => {});
