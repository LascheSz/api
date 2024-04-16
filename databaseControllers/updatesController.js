const Updates = require('../databaseModels/updateModel.js');

exports.getUpdate = async (req, res) => {
    try {
        const result = await Updates.getUpdates();
        res.status(200).json(result);
    } catch (error) {
        res.status(500).json({ message: error.message });
    }
};

exports.addUpdate = async (req, res, next) => {
    try {
        let formdata = req.body;
        console.log(formdata);
        res.redirect("/update");
    }catch (e) {
        console.log(e.message)
    }
}