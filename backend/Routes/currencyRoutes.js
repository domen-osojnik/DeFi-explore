const currencyController = require('../Controllers/currencyController');
const express = require('express');
const router = express.Router();

router.get('/', currencyController.index);

module.exports = router;