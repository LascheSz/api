import { db } from '../database/db.js';

class Updates {
    static async getUpdates() {
        try {
            const [rows, fields] = await db.promise().query('SELECT * FROM updates;');
            return rows;
        } catch (error) {
            console.error(error);
            return null;
        }
    }
}

module.exports = Updates;
