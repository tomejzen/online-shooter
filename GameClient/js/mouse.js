﻿let mouse = {

    MOUSE_MOVE_FACTOR: 3000,

    initialize: function () {

        this.canvas = document.querySelector('canvas');

        this.rotation = 0;
        this.x = 0;
        this.y = 0;
        
        // Option to leave lock
        document.exitPointerLock = document.exitPointerLock ||
            document.mozExitPointerLock;

        // On click canvas lock pointer
        this.canvas.requestPointerLock = this.canvas.requestPointerLock ||
            this.canvas.mozRequestPointerLock;
        this.canvas.onclick = function () {
            this.requestPointerLock();
        };

        // On pointer lock status changed
        document.addEventListener('pointerlockchange', mouse.lockChangeAlert, false);
        document.addEventListener('mozpointerlockchange', mouse.lockChangeAlert, false);
    },

    lockChangeAlert: function () {
        if (document.pointerLockElement === mouse.canvas ||
            document.mozPointerLockElement === mouse.canvas) {

            document.addEventListener("mousemove", mouse.updatePosition, false);
        } else {

            document.removeEventListener("mousemove", mouse.updatePosition, false);
        }
    },

    updatePosition: function (e) {

        if (config.DEBUG_STOP)
            return;
        
        // this.rotation is horizontal rotation
        this.rotation += e.movementX / mouse.MOUSE_MOVE_FACTOR * config.SENSITIVITY;
        
        // Normalize rotation from 0 to 2PI
        let d = Math.floor(this.rotation / (2 * Math.PI));
        this.rotation -= d * (2 * Math.PI);

    },

    getCurrentAngles: function () {

        return {
            X: 0,
            Y: this.rotation
        };
    }




};

