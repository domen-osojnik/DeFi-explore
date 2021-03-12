const usersController = require('../Controllers/usersController')
const express = require('express');
const router = express.Router();

//my middleware
function consoleLogHello (req, res, next)
{
    console.log("Hello!");
    next();
}
router.use(consoleLogHello);
//get
router.get('/', usersController.index);
//post
//set
//delete

module.exports = router;