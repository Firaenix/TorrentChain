/******/ (function(modules) { // webpackBootstrap
/******/ 	// install a JSONP callback for chunk loading
/******/ 	function webpackJsonpCallback(data) {
/******/ 		var chunkIds = data[0];
/******/ 		var moreModules = data[1];
/******/ 		var executeModules = data[2];
/******/ 		// add "moreModules" to the modules object,
/******/ 		// then flag all "chunkIds" as loaded and fire callback
/******/ 		var moduleId, chunkId, i = 0, resolves = [];
/******/ 		for(;i < chunkIds.length; i++) {
/******/ 			chunkId = chunkIds[i];
/******/ 			if(installedChunks[chunkId]) {
/******/ 				resolves.push(installedChunks[chunkId][0]);
/******/ 			}
/******/ 			installedChunks[chunkId] = 0;
/******/ 		}
/******/ 		for(moduleId in moreModules) {
/******/ 			if(Object.prototype.hasOwnProperty.call(moreModules, moduleId)) {
/******/ 				modules[moduleId] = moreModules[moduleId];
/******/ 			}
/******/ 		}
/******/ 		if(parentJsonpFunction) parentJsonpFunction(data);
/******/ 		while(resolves.length) {
/******/ 			resolves.shift()();
/******/ 		}
/******/
/******/ 		// add entry modules from loaded chunk to deferred list
/******/ 		deferredModules.push.apply(deferredModules, executeModules || []);
/******/
/******/ 		// run deferred modules when all chunks ready
/******/ 		return checkDeferredModules();
/******/ 	};
/******/ 	function checkDeferredModules() {
/******/ 		var result;
/******/ 		for(var i = 0; i < deferredModules.length; i++) {
/******/ 			var deferredModule = deferredModules[i];
/******/ 			var fulfilled = true;
/******/ 			for(var j = 1; j < deferredModule.length; j++) {
/******/ 				var depId = deferredModule[j];
/******/ 				if(installedChunks[depId] !== 0) fulfilled = false;
/******/ 			}
/******/ 			if(fulfilled) {
/******/ 				deferredModules.splice(i--, 1);
/******/ 				result = __webpack_require__(__webpack_require__.s = deferredModule[0]);
/******/ 			}
/******/ 		}
/******/ 		return result;
/******/ 	}
/******/
/******/ 	// The module cache
/******/ 	var installedModules = {};
/******/
/******/ 	// object to store loaded and loading chunks
/******/ 	var installedChunks = {
/******/ 		"app": 0
/******/ 	};
/******/
/******/ 	var deferredModules = [];
/******/
/******/ 	// The require function
/******/ 	function __webpack_require__(moduleId) {
/******/
/******/ 		// Check if module is in cache
/******/ 		if(installedModules[moduleId]) {
/******/ 			return installedModules[moduleId].exports;
/******/ 		}
/******/ 		// Create a new module (and put it into the cache)
/******/ 		var module = installedModules[moduleId] = {
/******/ 			i: moduleId,
/******/ 			l: false,
/******/ 			exports: {}
/******/ 		};
/******/
/******/ 		// Execute the module function
/******/ 		modules[moduleId].call(module.exports, module, module.exports, __webpack_require__);
/******/
/******/ 		// Flag the module as loaded
/******/ 		module.l = true;
/******/
/******/ 		// Return the exports of the module
/******/ 		return module.exports;
/******/ 	}
/******/
/******/
/******/ 	// expose the modules object (__webpack_modules__)
/******/ 	__webpack_require__.m = modules;
/******/
/******/ 	// expose the module cache
/******/ 	__webpack_require__.c = installedModules;
/******/
/******/ 	// define getter function for harmony exports
/******/ 	__webpack_require__.d = function(exports, name, getter) {
/******/ 		if(!__webpack_require__.o(exports, name)) {
/******/ 			Object.defineProperty(exports, name, {
/******/ 				configurable: false,
/******/ 				enumerable: true,
/******/ 				get: getter
/******/ 			});
/******/ 		}
/******/ 	};
/******/
/******/ 	// define __esModule on exports
/******/ 	__webpack_require__.r = function(exports) {
/******/ 		Object.defineProperty(exports, '__esModule', { value: true });
/******/ 	};
/******/
/******/ 	// getDefaultExport function for compatibility with non-harmony modules
/******/ 	__webpack_require__.n = function(module) {
/******/ 		var getter = module && module.__esModule ?
/******/ 			function getDefault() { return module['default']; } :
/******/ 			function getModuleExports() { return module; };
/******/ 		__webpack_require__.d(getter, 'a', getter);
/******/ 		return getter;
/******/ 	};
/******/
/******/ 	// Object.prototype.hasOwnProperty.call
/******/ 	__webpack_require__.o = function(object, property) { return Object.prototype.hasOwnProperty.call(object, property); };
/******/
/******/ 	// __webpack_public_path__
/******/ 	__webpack_require__.p = "";
/******/
/******/ 	var jsonpArray = window["webpackJsonp"] = window["webpackJsonp"] || [];
/******/ 	var oldJsonpFunction = jsonpArray.push.bind(jsonpArray);
/******/ 	jsonpArray.push = webpackJsonpCallback;
/******/ 	jsonpArray = jsonpArray.slice();
/******/ 	for(var i = 0; i < jsonpArray.length; i++) webpackJsonpCallback(jsonpArray[i]);
/******/ 	var parentJsonpFunction = oldJsonpFunction;
/******/
/******/
/******/ 	// add entry module to deferred list
/******/ 	deferredModules.push([0,"vendor"]);
/******/ 	// run deferred modules when ready
/******/ 	return checkDeferredModules();
/******/ })
/************************************************************************/
/******/ ({

/***/ "./TorrentChain.FrontEnd/Components/Block.tsx":
/*!****************************************************!*\
  !*** ./TorrentChain.FrontEnd/Components/Block.tsx ***!
  \****************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

"use strict";
eval("\r\nvar __extends = (this && this.__extends) || (function () {\r\n    var extendStatics = Object.setPrototypeOf ||\r\n        ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||\r\n        function (d, b) { for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p]; };\r\n    return function (d, b) {\r\n        extendStatics(d, b);\r\n        function __() { this.constructor = d; }\r\n        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());\r\n    };\r\n})();\r\nObject.defineProperty(exports, \"__esModule\", { value: true });\r\nvar React = __webpack_require__(/*! react */ \"./node_modules/react/index.js\");\r\nvar Block = /** @class */ (function (_super) {\r\n    __extends(Block, _super);\r\n    function Block() {\r\n        return _super !== null && _super.apply(this, arguments) || this;\r\n    }\r\n    Block.prototype.renderTorrentInfo = function () {\r\n        var block = this.props.block;\r\n        if (!block.torrentInfo) {\r\n            return null;\r\n        }\r\n        return (React.createElement(\"div\", null,\r\n            React.createElement(\"div\", null,\r\n                React.createElement(\"span\", { className: \"block-info\" }, \"Magnet Link: \"),\r\n                React.createElement(\"a\", { href: block.magnetLink }, block.magnetLink)),\r\n            React.createElement(\"div\", null,\r\n                React.createElement(\"span\", { className: \"block-info\" }, \"Number Of Pieces: \"),\r\n                block.torrentInfo.numberOfPieces),\r\n            React.createElement(\"div\", null,\r\n                React.createElement(\"span\", { className: \"block-info\" }, \"Display Name: \"),\r\n                block.torrentInfo.displayName),\r\n            React.createElement(\"div\", null,\r\n                React.createElement(\"span\", { className: \"block-info\" }, \"Trackers: \"),\r\n                JSON.stringify(block.torrentInfo.trackers))));\r\n    };\r\n    Block.prototype.renderBlockInfo = function () {\r\n        var block = this.props.block;\r\n        return (React.createElement(\"div\", null,\r\n            React.createElement(\"div\", null,\r\n                React.createElement(\"span\", { className: \"block-info\" }, \"Index: \"),\r\n                block.index),\r\n            React.createElement(\"div\", null,\r\n                React.createElement(\"span\", { className: \"block-info\" }, \"Hash: \"),\r\n                block.hash),\r\n            React.createElement(\"div\", null,\r\n                React.createElement(\"span\", { className: \"block-info\" }, \"Previous Hash: \"),\r\n                block.previousHash),\r\n            React.createElement(\"div\", null,\r\n                React.createElement(\"span\", { className: \"block-info\" }, \"Timestamp: \"),\r\n                block.timeStamp),\r\n            this.renderTorrentInfo()));\r\n    };\r\n    Block.prototype.renderArrow = function () {\r\n        if (!this.props.block.previousHash) {\r\n            return null;\r\n        }\r\n        return React.createElement(\"div\", null, \"^\");\r\n    };\r\n    Block.prototype.render = function () {\r\n        return (React.createElement(React.Fragment, null,\r\n            this.renderArrow(),\r\n            React.createElement(\"div\", { className: \"block-container\" }, this.renderBlockInfo())));\r\n    };\r\n    return Block;\r\n}(React.Component));\r\nexports.Block = Block;\r\n//# sourceURL=[module]\n//# sourceMappingURL=data:application/json;charset=utf-8;base64,eyJ2ZXJzaW9uIjozLCJmaWxlIjoiLi9Ub3JyZW50Q2hhaW4uRnJvbnRFbmQvQ29tcG9uZW50cy9CbG9jay50c3guanMiLCJzb3VyY2VzIjpbIndlYnBhY2s6Ly8vLi9Ub3JyZW50Q2hhaW4uRnJvbnRFbmQvQ29tcG9uZW50cy9CbG9jay50c3g/NzE2NiJdLCJzb3VyY2VzQ29udGVudCI6WyJpbXBvcnQgeyBCbG9ja01vZGVsIH0gZnJvbSAnTW9kZWwvQmxvY2tNb2RlbCc7XG5pbXBvcnQgKiBhcyBSZWFjdCBmcm9tICdyZWFjdCc7XG5cbmludGVyZmFjZSBQcm9wcyB7XG4gIGJsb2NrOiBCbG9ja01vZGVsO1xufVxuXG5leHBvcnQgY2xhc3MgQmxvY2sgZXh0ZW5kcyBSZWFjdC5Db21wb25lbnQ8UHJvcHM+IHtcbiAgcHJpdmF0ZSByZW5kZXJUb3JyZW50SW5mbygpIHtcbiAgICBjb25zdCB7IGJsb2NrIH0gPSB0aGlzLnByb3BzO1xuICAgIGlmICghYmxvY2sudG9ycmVudEluZm8pIHtcbiAgICAgIHJldHVybiBudWxsO1xuICAgIH1cblxuICAgIHJldHVybiAoXG4gICAgICA8ZGl2PlxuICAgICAgICA8ZGl2PlxuICAgICAgICAgIDxzcGFuIGNsYXNzTmFtZT1cImJsb2NrLWluZm9cIj5NYWduZXQgTGluazogPC9zcGFuPlxuICAgICAgICAgIDxhIGhyZWY9e2Jsb2NrLm1hZ25ldExpbmt9PntibG9jay5tYWduZXRMaW5rfTwvYT5cbiAgICAgICAgPC9kaXY+XG4gICAgICAgIDxkaXY+XG4gICAgICAgICAgPHNwYW4gY2xhc3NOYW1lPVwiYmxvY2staW5mb1wiPk51bWJlciBPZiBQaWVjZXM6IDwvc3Bhbj5cbiAgICAgICAgICB7YmxvY2sudG9ycmVudEluZm8ubnVtYmVyT2ZQaWVjZXN9XG4gICAgICAgIDwvZGl2PlxuICAgICAgICA8ZGl2PlxuICAgICAgICAgIDxzcGFuIGNsYXNzTmFtZT1cImJsb2NrLWluZm9cIj5EaXNwbGF5IE5hbWU6IDwvc3Bhbj5cbiAgICAgICAgICB7YmxvY2sudG9ycmVudEluZm8uZGlzcGxheU5hbWV9XG4gICAgICAgIDwvZGl2PlxuICAgICAgICA8ZGl2PlxuICAgICAgICAgIDxzcGFuIGNsYXNzTmFtZT1cImJsb2NrLWluZm9cIj5UcmFja2VyczogPC9zcGFuPlxuICAgICAgICAgIHtKU09OLnN0cmluZ2lmeShibG9jay50b3JyZW50SW5mby50cmFja2Vycyl9XG4gICAgICAgIDwvZGl2PlxuICAgICAgPC9kaXY+XG4gICAgKTtcbiAgfVxuXG4gIHByaXZhdGUgcmVuZGVyQmxvY2tJbmZvKCkge1xuICAgIGNvbnN0IHsgYmxvY2sgfSA9IHRoaXMucHJvcHM7XG4gICAgcmV0dXJuIChcbiAgICAgIDxkaXY+XG4gICAgICAgIDxkaXY+XG4gICAgICAgICAgPHNwYW4gY2xhc3NOYW1lPVwiYmxvY2staW5mb1wiPkluZGV4OiA8L3NwYW4+XG4gICAgICAgICAge2Jsb2NrLmluZGV4fVxuICAgICAgICA8L2Rpdj5cbiAgICAgICAgPGRpdj5cbiAgICAgICAgICA8c3BhbiBjbGFzc05hbWU9XCJibG9jay1pbmZvXCI+SGFzaDogPC9zcGFuPlxuICAgICAgICAgIHtibG9jay5oYXNofVxuICAgICAgICA8L2Rpdj5cbiAgICAgICAgPGRpdj5cbiAgICAgICAgICA8c3BhbiBjbGFzc05hbWU9XCJibG9jay1pbmZvXCI+UHJldmlvdXMgSGFzaDogPC9zcGFuPlxuICAgICAgICAgIHtibG9jay5wcmV2aW91c0hhc2h9XG4gICAgICAgIDwvZGl2PlxuICAgICAgICA8ZGl2PlxuICAgICAgICAgIDxzcGFuIGNsYXNzTmFtZT1cImJsb2NrLWluZm9cIj5UaW1lc3RhbXA6IDwvc3Bhbj5cbiAgICAgICAgICB7YmxvY2sudGltZVN0YW1wfVxuICAgICAgICA8L2Rpdj5cbiAgICAgICAge3RoaXMucmVuZGVyVG9ycmVudEluZm8oKX1cbiAgICAgIDwvZGl2PlxuICAgICk7XG4gIH1cblxuICBwcml2YXRlIHJlbmRlckFycm93KCkge1xuICAgIGlmICghdGhpcy5wcm9wcy5ibG9jay5wcmV2aW91c0hhc2gpIHtcbiAgICAgIHJldHVybiBudWxsO1xuICAgIH1cblxuICAgIHJldHVybiA8ZGl2Pl48L2Rpdj47XG4gIH1cblxuICBwdWJsaWMgcmVuZGVyKCkge1xuICAgIHJldHVybiAoXG4gICAgICA8PlxuICAgICAgICB7dGhpcy5yZW5kZXJBcnJvdygpfVxuICAgICAgICA8ZGl2IGNsYXNzTmFtZT1cImJsb2NrLWNvbnRhaW5lclwiPnt0aGlzLnJlbmRlckJsb2NrSW5mbygpfTwvZGl2PlxuICAgICAgPC8+XG4gICAgKTtcbiAgfVxufVxuIl0sIm1hcHBpbmdzIjoiOzs7Ozs7Ozs7Ozs7QUFDQTtBQU1BO0FBQUE7QUFBQTs7QUFzRUE7QUFyRUE7QUFDQTtBQUNBO0FBQ0E7QUFDQTtBQUVBO0FBRUE7QUFDQTtBQUNBO0FBRUE7QUFDQTtBQUNBO0FBRUE7QUFDQTtBQUNBO0FBRUE7QUFDQTtBQUNBO0FBSUE7QUFFQTtBQUNBO0FBQ0E7QUFFQTtBQUNBO0FBQ0E7QUFFQTtBQUNBO0FBQ0E7QUFFQTtBQUNBO0FBQ0E7QUFFQTtBQUNBO0FBQ0E7QUFFQTtBQUdBO0FBRUE7QUFDQTtBQUNBO0FBQ0E7QUFFQTtBQUNBO0FBRUE7QUFDQTtBQUVBO0FBQ0E7QUFHQTtBQUNBO0FBQUE7QUF0RUE7Iiwic291cmNlUm9vdCI6IiJ9\n//# sourceURL=webpack-internal:///./TorrentChain.FrontEnd/Components/Block.tsx\n");

/***/ }),

/***/ "./TorrentChain.FrontEnd/Components/BlockChain/BlockChain.tsx":
/*!********************************************************************!*\
  !*** ./TorrentChain.FrontEnd/Components/BlockChain/BlockChain.tsx ***!
  \********************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

"use strict";
eval("\r\nvar __extends = (this && this.__extends) || (function () {\r\n    var extendStatics = Object.setPrototypeOf ||\r\n        ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||\r\n        function (d, b) { for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p]; };\r\n    return function (d, b) {\r\n        extendStatics(d, b);\r\n        function __() { this.constructor = d; }\r\n        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());\r\n    };\r\n})();\r\nObject.defineProperty(exports, \"__esModule\", { value: true });\r\nvar React = __webpack_require__(/*! react */ \"./node_modules/react/index.js\");\r\nvar react_1 = __webpack_require__(/*! redux-zero/react */ \"./node_modules/redux-zero/react/index.js\");\r\nvar Block_1 = __webpack_require__(/*! ../Block */ \"./TorrentChain.FrontEnd/Components/Block.tsx\");\r\nvar BlockChainActions_1 = __webpack_require__(/*! ./BlockChainActions */ \"./TorrentChain.FrontEnd/Components/BlockChain/BlockChainActions.ts\");\r\nvar BlockChainComponent = /** @class */ (function (_super) {\r\n    __extends(BlockChainComponent, _super);\r\n    function BlockChainComponent(props) {\r\n        var _this = _super.call(this, props) || this;\r\n        props.getBlockChain();\r\n        return _this;\r\n    }\r\n    BlockChainComponent.prototype.renderBlocks = function () {\r\n        var blocks = this.props.blocks;\r\n        if (!blocks) {\r\n            return React.createElement(\"div\", null, \"No Blocks\");\r\n        }\r\n        return blocks.map(function (x) { return React.createElement(Block_1.Block, { key: x.hash, block: x }); });\r\n    };\r\n    BlockChainComponent.prototype.render = function () {\r\n        return this.renderBlocks();\r\n    };\r\n    return BlockChainComponent;\r\n}(React.Component));\r\nexports.BlockChainComponent = BlockChainComponent;\r\nexports.BlockChain = react_1.connect(function (state) { return ({\r\n    blocks: state.blockChain\r\n}); }, BlockChainActions_1.BlockChainActions)(BlockChainComponent);\r\n//# sourceURL=[module]\n//# sourceMappingURL=data:application/json;charset=utf-8;base64,eyJ2ZXJzaW9uIjozLCJmaWxlIjoiLi9Ub3JyZW50Q2hhaW4uRnJvbnRFbmQvQ29tcG9uZW50cy9CbG9ja0NoYWluL0Jsb2NrQ2hhaW4udHN4LmpzIiwic291cmNlcyI6WyJ3ZWJwYWNrOi8vLy4vVG9ycmVudENoYWluLkZyb250RW5kL0NvbXBvbmVudHMvQmxvY2tDaGFpbi9CbG9ja0NoYWluLnRzeD84MzViIl0sInNvdXJjZXNDb250ZW50IjpbImltcG9ydCB7IEJsb2NrTW9kZWwgfSBmcm9tICdNb2RlbC9CbG9ja01vZGVsJztcbmltcG9ydCAqIGFzIFJlYWN0IGZyb20gJ3JlYWN0JztcbmltcG9ydCB7IGNvbm5lY3QgfSBmcm9tICdyZWR1eC16ZXJvL3JlYWN0JztcblxuaW1wb3J0IHsgR2xvYmFsU3RhdGUgfSBmcm9tICcuLi8uLi9zdG9yZSc7XG5pbXBvcnQgeyBCbG9jayB9IGZyb20gJy4uL0Jsb2NrJztcbmltcG9ydCB7IEJsb2NrQ2hhaW5BY3Rpb25zIH0gZnJvbSAnLi9CbG9ja0NoYWluQWN0aW9ucyc7XG5cbmludGVyZmFjZSBQcm9wcyB7XG4gIGJsb2NrczogQXJyYXk8QmxvY2tNb2RlbD47XG5cbiAgZ2V0QmxvY2tDaGFpbjogKCkgPT4gdm9pZDtcbn1cblxuZXhwb3J0IGNsYXNzIEJsb2NrQ2hhaW5Db21wb25lbnQgZXh0ZW5kcyBSZWFjdC5Db21wb25lbnQ8UHJvcHM+IHtcbiAgY29uc3RydWN0b3IocHJvcHM6IFByb3BzKSB7XG4gICAgc3VwZXIocHJvcHMpO1xuXG4gICAgcHJvcHMuZ2V0QmxvY2tDaGFpbigpO1xuICB9XG5cbiAgcHJpdmF0ZSByZW5kZXJCbG9ja3MoKSB7XG4gICAgY29uc3QgeyBibG9ja3MgfSA9IHRoaXMucHJvcHM7XG4gICAgaWYgKCFibG9ja3MpIHtcbiAgICAgIHJldHVybiA8ZGl2Pk5vIEJsb2NrczwvZGl2PjtcbiAgICB9XG5cbiAgICByZXR1cm4gYmxvY2tzLm1hcCh4ID0+IDxCbG9jayBrZXk9e3guaGFzaH0gYmxvY2s9e3h9IC8+KTtcbiAgfVxuXG4gIHB1YmxpYyByZW5kZXIoKSB7XG4gICAgcmV0dXJuIHRoaXMucmVuZGVyQmxvY2tzKCk7XG4gIH1cbn1cblxuZXhwb3J0IGNvbnN0IEJsb2NrQ2hhaW4gPSBjb25uZWN0KFxuICAoc3RhdGU6IEdsb2JhbFN0YXRlKTogUGFydGlhbDxQcm9wcz4gPT4gKHtcbiAgICBibG9ja3M6IHN0YXRlLmJsb2NrQ2hhaW5cbiAgfSksXG4gIEJsb2NrQ2hhaW5BY3Rpb25zXG4pKEJsb2NrQ2hhaW5Db21wb25lbnQpO1xuIl0sIm1hcHBpbmdzIjoiOzs7Ozs7Ozs7Ozs7QUFDQTtBQUNBO0FBR0E7QUFDQTtBQVFBO0FBQUE7QUFDQTtBQUFBO0FBR0E7O0FBQ0E7QUFFQTtBQUNBO0FBQ0E7QUFDQTtBQUNBO0FBRUE7QUFDQTtBQUVBO0FBQ0E7QUFDQTtBQUNBO0FBQUE7QUFuQkE7QUFxQkE7QUFFQTtBQUNBOyIsInNvdXJjZVJvb3QiOiIifQ==\n//# sourceURL=webpack-internal:///./TorrentChain.FrontEnd/Components/BlockChain/BlockChain.tsx\n");

/***/ }),

/***/ "./TorrentChain.FrontEnd/Components/BlockChain/BlockChainActions.ts":
/*!**************************************************************************!*\
  !*** ./TorrentChain.FrontEnd/Components/BlockChain/BlockChainActions.ts ***!
  \**************************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

"use strict";
eval("\r\nvar __assign = (this && this.__assign) || Object.assign || function(t) {\r\n    for (var s, i = 1, n = arguments.length; i < n; i++) {\r\n        s = arguments[i];\r\n        for (var p in s) if (Object.prototype.hasOwnProperty.call(s, p))\r\n            t[p] = s[p];\r\n    }\r\n    return t;\r\n};\r\nvar __awaiter = (this && this.__awaiter) || function (thisArg, _arguments, P, generator) {\r\n    return new (P || (P = Promise))(function (resolve, reject) {\r\n        function fulfilled(value) { try { step(generator.next(value)); } catch (e) { reject(e); } }\r\n        function rejected(value) { try { step(generator[\"throw\"](value)); } catch (e) { reject(e); } }\r\n        function step(result) { result.done ? resolve(result.value) : new P(function (resolve) { resolve(result.value); }).then(fulfilled, rejected); }\r\n        step((generator = generator.apply(thisArg, _arguments || [])).next());\r\n    });\r\n};\r\nvar __generator = (this && this.__generator) || function (thisArg, body) {\r\n    var _ = { label: 0, sent: function() { if (t[0] & 1) throw t[1]; return t[1]; }, trys: [], ops: [] }, f, y, t, g;\r\n    return g = { next: verb(0), \"throw\": verb(1), \"return\": verb(2) }, typeof Symbol === \"function\" && (g[Symbol.iterator] = function() { return this; }), g;\r\n    function verb(n) { return function (v) { return step([n, v]); }; }\r\n    function step(op) {\r\n        if (f) throw new TypeError(\"Generator is already executing.\");\r\n        while (_) try {\r\n            if (f = 1, y && (t = y[op[0] & 2 ? \"return\" : op[0] ? \"throw\" : \"next\"]) && !(t = t.call(y, op[1])).done) return t;\r\n            if (y = 0, t) op = [0, t.value];\r\n            switch (op[0]) {\r\n                case 0: case 1: t = op; break;\r\n                case 4: _.label++; return { value: op[1], done: false };\r\n                case 5: _.label++; y = op[1]; op = [0]; continue;\r\n                case 7: op = _.ops.pop(); _.trys.pop(); continue;\r\n                default:\r\n                    if (!(t = _.trys, t = t.length > 0 && t[t.length - 1]) && (op[0] === 6 || op[0] === 2)) { _ = 0; continue; }\r\n                    if (op[0] === 3 && (!t || (op[1] > t[0] && op[1] < t[3]))) { _.label = op[1]; break; }\r\n                    if (op[0] === 6 && _.label < t[1]) { _.label = t[1]; t = op; break; }\r\n                    if (t && _.label < t[2]) { _.label = t[2]; _.ops.push(op); break; }\r\n                    if (t[2]) _.ops.pop();\r\n                    _.trys.pop(); continue;\r\n            }\r\n            op = body.call(thisArg, _);\r\n        } catch (e) { op = [6, e]; y = 0; } finally { f = t = 0; }\r\n        if (op[0] & 5) throw op[1]; return { value: op[0] ? op[1] : void 0, done: true };\r\n    }\r\n};\r\nvar _this = this;\r\nObject.defineProperty(exports, \"__esModule\", { value: true });\r\nvar axios_1 = __webpack_require__(/*! axios */ \"./node_modules/axios/index.js\");\r\n/* actions.js */\r\nexports.BlockChainActions = function (store) { return ({\r\n    getBlockChain: function (state) { return __awaiter(_this, void 0, void 0, function () {\r\n        var response;\r\n        return __generator(this, function (_a) {\r\n            switch (_a.label) {\r\n                case 0: return [4 /*yield*/, axios_1.default.get('/api/blockchain')];\r\n                case 1:\r\n                    response = _a.sent();\r\n                    return [2 /*return*/, __assign({}, state, { blockChain: response.data })];\r\n            }\r\n        });\r\n    }); }\r\n}); };\r\n//# sourceURL=[module]\n//# sourceMappingURL=data:application/json;charset=utf-8;base64,eyJ2ZXJzaW9uIjozLCJmaWxlIjoiLi9Ub3JyZW50Q2hhaW4uRnJvbnRFbmQvQ29tcG9uZW50cy9CbG9ja0NoYWluL0Jsb2NrQ2hhaW5BY3Rpb25zLnRzLmpzIiwic291cmNlcyI6WyJ3ZWJwYWNrOi8vLy4vVG9ycmVudENoYWluLkZyb250RW5kL0NvbXBvbmVudHMvQmxvY2tDaGFpbi9CbG9ja0NoYWluQWN0aW9ucy50cz8wMWExIl0sInNvdXJjZXNDb250ZW50IjpbImltcG9ydCBheGlvcyBmcm9tICdheGlvcyc7XG5pbXBvcnQgeyBHbG9iYWxTdGF0ZSB9IGZyb20gJ3N0b3JlJztcblxuLyogYWN0aW9ucy5qcyAqL1xuZXhwb3J0IGNvbnN0IEJsb2NrQ2hhaW5BY3Rpb25zID0gKHN0b3JlOiBhbnkpID0+ICh7XG4gIGdldEJsb2NrQ2hhaW46IGFzeW5jIChzdGF0ZTogR2xvYmFsU3RhdGUpOiBQcm9taXNlPFBhcnRpYWw8R2xvYmFsU3RhdGU+PiA9PiB7XG4gICAgY29uc3QgcmVzcG9uc2UgPSBhd2FpdCBheGlvcy5nZXQoJy9hcGkvYmxvY2tjaGFpbicpO1xuXG4gICAgcmV0dXJuIHtcbiAgICAgIC4uLnN0YXRlLFxuICAgICAgYmxvY2tDaGFpbjogcmVzcG9uc2UuZGF0YVxuICAgIH07XG4gIH1cbn0pO1xuIl0sIm1hcHBpbmdzIjoiOzs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7OztBQUFBOztBQUFBO0FBR0E7QUFDQTtBQUNBOzs7O0FBQ0E7O0FBQUE7QUFFQTs7O0FBSUE7QUFDQTsiLCJzb3VyY2VSb290IjoiIn0=\n//# sourceURL=webpack-internal:///./TorrentChain.FrontEnd/Components/BlockChain/BlockChainActions.ts\n");

/***/ }),

/***/ "./TorrentChain.FrontEnd/Styles/base.scss":
/*!************************************************!*\
  !*** ./TorrentChain.FrontEnd/Styles/base.scss ***!
  \************************************************/
/*! no static exports found */
/***/ (function(module, exports) {

eval("// removed by extract-text-webpack-plugin//# sourceURL=[module]\n//# sourceMappingURL=data:application/json;charset=utf-8;base64,eyJ2ZXJzaW9uIjozLCJmaWxlIjoiLi9Ub3JyZW50Q2hhaW4uRnJvbnRFbmQvU3R5bGVzL2Jhc2Uuc2Nzcy5qcyIsInNvdXJjZXMiOlsid2VicGFjazovLy8uL1RvcnJlbnRDaGFpbi5Gcm9udEVuZC9TdHlsZXMvYmFzZS5zY3NzPzFlOTEiXSwic291cmNlc0NvbnRlbnQiOlsiLy8gcmVtb3ZlZCBieSBleHRyYWN0LXRleHQtd2VicGFjay1wbHVnaW4iXSwibWFwcGluZ3MiOiJBQUFBIiwic291cmNlUm9vdCI6IiJ9\n//# sourceURL=webpack-internal:///./TorrentChain.FrontEnd/Styles/base.scss\n");

/***/ }),

/***/ "./TorrentChain.FrontEnd/index.tsx":
/*!*****************************************!*\
  !*** ./TorrentChain.FrontEnd/index.tsx ***!
  \*****************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

"use strict";
eval("\r\nObject.defineProperty(exports, \"__esModule\", { value: true });\r\n__webpack_require__(/*! ./Styles/base.scss */ \"./TorrentChain.FrontEnd/Styles/base.scss\");\r\nvar BlockChain_1 = __webpack_require__(/*! Components/BlockChain/BlockChain */ \"./TorrentChain.FrontEnd/Components/BlockChain/BlockChain.tsx\");\r\nvar React = __webpack_require__(/*! react */ \"./node_modules/react/index.js\");\r\nvar ReactDOM = __webpack_require__(/*! react-dom */ \"./node_modules/react-dom/index.js\");\r\nvar ReduxZero = __webpack_require__(/*! redux-zero/react */ \"./node_modules/redux-zero/react/index.js\");\r\nvar store_1 = __webpack_require__(/*! ./store */ \"./TorrentChain.FrontEnd/store.ts\");\r\nReactDOM.render(React.createElement(ReduxZero.Provider, { store: store_1.store },\r\n    React.createElement(BlockChain_1.BlockChain, null)), document.getElementById('root'));\r\n//# sourceURL=[module]\n//# sourceMappingURL=data:application/json;charset=utf-8;base64,eyJ2ZXJzaW9uIjozLCJmaWxlIjoiLi9Ub3JyZW50Q2hhaW4uRnJvbnRFbmQvaW5kZXgudHN4LmpzIiwic291cmNlcyI6WyJ3ZWJwYWNrOi8vLy4vVG9ycmVudENoYWluLkZyb250RW5kL2luZGV4LnRzeD9iOWFmIl0sInNvdXJjZXNDb250ZW50IjpbImltcG9ydCAnLi9TdHlsZXMvYmFzZS5zY3NzJztcblxuaW1wb3J0IHsgQmxvY2tDaGFpbiB9IGZyb20gJ0NvbXBvbmVudHMvQmxvY2tDaGFpbi9CbG9ja0NoYWluJztcbmltcG9ydCAqIGFzIFJlYWN0IGZyb20gJ3JlYWN0JztcbmltcG9ydCAqIGFzIFJlYWN0RE9NIGZyb20gJ3JlYWN0LWRvbSc7XG5pbXBvcnQgKiBhcyBSZWR1eFplcm8gZnJvbSAncmVkdXgtemVyby9yZWFjdCc7XG5cbmltcG9ydCB7IHN0b3JlIH0gZnJvbSAnLi9zdG9yZSc7XG5cblJlYWN0RE9NLnJlbmRlcihcbiAgPFJlZHV4WmVyby5Qcm92aWRlciBzdG9yZT17c3RvcmV9PlxuICAgIDxCbG9ja0NoYWluIC8+XG4gIDwvUmVkdXhaZXJvLlByb3ZpZGVyPixcbiAgZG9jdW1lbnQuZ2V0RWxlbWVudEJ5SWQoJ3Jvb3QnKVxuKTtcbiJdLCJtYXBwaW5ncyI6Ijs7QUFBQTtBQUVBO0FBQ0E7QUFDQTtBQUNBO0FBRUE7QUFFQTtBQUVBOyIsInNvdXJjZVJvb3QiOiIifQ==\n//# sourceURL=webpack-internal:///./TorrentChain.FrontEnd/index.tsx\n");

/***/ }),

/***/ "./TorrentChain.FrontEnd/store.ts":
/*!****************************************!*\
  !*** ./TorrentChain.FrontEnd/store.ts ***!
  \****************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

"use strict";
eval("\r\nObject.defineProperty(exports, \"__esModule\", { value: true });\r\nvar createStore = __webpack_require__(/*! redux-zero */ \"./node_modules/redux-zero/dist/redux-zero.js\");\r\nvar createStoreHack = createStore;\r\nvar GlobalState = /** @class */ (function () {\r\n    function GlobalState() {\r\n    }\r\n    return GlobalState;\r\n}());\r\nexports.GlobalState = GlobalState;\r\nexports.store = createStoreHack(new GlobalState());\r\n//# sourceURL=[module]\n//# sourceMappingURL=data:application/json;charset=utf-8;base64,eyJ2ZXJzaW9uIjozLCJmaWxlIjoiLi9Ub3JyZW50Q2hhaW4uRnJvbnRFbmQvc3RvcmUudHMuanMiLCJzb3VyY2VzIjpbIndlYnBhY2s6Ly8vLi9Ub3JyZW50Q2hhaW4uRnJvbnRFbmQvc3RvcmUudHM/YzlkMiJdLCJzb3VyY2VzQ29udGVudCI6WyJpbXBvcnQgKiBhcyBjcmVhdGVTdG9yZSBmcm9tICdyZWR1eC16ZXJvJztcblxuaW1wb3J0IHsgQmxvY2tNb2RlbCB9IGZyb20gJy4vTW9kZWwvQmxvY2tNb2RlbCc7XG5cbmNvbnN0IGNyZWF0ZVN0b3JlSGFjazogYW55ID0gY3JlYXRlU3RvcmU7XG5cbmV4cG9ydCBjbGFzcyBHbG9iYWxTdGF0ZSB7XG4gIGJsb2NrQ2hhaW46IEFycmF5PEJsb2NrTW9kZWw+O1xufVxuXG5leHBvcnQgY29uc3Qgc3RvcmUgPSBjcmVhdGVTdG9yZUhhY2sobmV3IEdsb2JhbFN0YXRlKCkpO1xuIl0sIm1hcHBpbmdzIjoiOztBQUFBO0FBSUE7QUFFQTtBQUFBO0FBRUE7QUFBQTtBQUFBO0FBRkE7QUFJQTsiLCJzb3VyY2VSb290IjoiIn0=\n//# sourceURL=webpack-internal:///./TorrentChain.FrontEnd/store.ts\n");

/***/ }),

/***/ "./node_modules/webpack/hot sync ^\\.\\/log$":
/*!*************************************************!*\
  !*** (webpack)/hot sync nonrecursive ^\.\/log$ ***!
  \*************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

eval("var map = {\n\t\"./log\": \"./node_modules/webpack/hot/log.js\"\n};\n\n\nfunction webpackContext(req) {\n\tvar id = webpackContextResolve(req);\n\tvar module = __webpack_require__(id);\n\treturn module;\n}\nfunction webpackContextResolve(req) {\n\tvar id = map[req];\n\tif(!(id + 1)) { // check for number or string\n\t\tvar e = new Error('Cannot find module \"' + req + '\".');\n\t\te.code = 'MODULE_NOT_FOUND';\n\t\tthrow e;\n\t}\n\treturn id;\n}\nwebpackContext.keys = function webpackContextKeys() {\n\treturn Object.keys(map);\n};\nwebpackContext.resolve = webpackContextResolve;\nmodule.exports = webpackContext;\nwebpackContext.id = \"./node_modules/webpack/hot sync ^\\\\.\\\\/log$\";//# sourceURL=[module]\n//# sourceMappingURL=data:application/json;charset=utf-8;base64,eyJ2ZXJzaW9uIjozLCJmaWxlIjoiLi9ub2RlX21vZHVsZXMvd2VicGFjay9ob3Qgc3luYyBeXFwuXFwvbG9nJC5qcyIsInNvdXJjZXMiOlsid2VicGFjazovLy8od2VicGFjaykvaG90IHN5bmMgbm9ucmVjdXJzaXZlIF5cXC5cXC9sb2ckPzFjM2QiXSwic291cmNlc0NvbnRlbnQiOlsidmFyIG1hcCA9IHtcblx0XCIuL2xvZ1wiOiBcIi4vbm9kZV9tb2R1bGVzL3dlYnBhY2svaG90L2xvZy5qc1wiXG59O1xuXG5cbmZ1bmN0aW9uIHdlYnBhY2tDb250ZXh0KHJlcSkge1xuXHR2YXIgaWQgPSB3ZWJwYWNrQ29udGV4dFJlc29sdmUocmVxKTtcblx0dmFyIG1vZHVsZSA9IF9fd2VicGFja19yZXF1aXJlX18oaWQpO1xuXHRyZXR1cm4gbW9kdWxlO1xufVxuZnVuY3Rpb24gd2VicGFja0NvbnRleHRSZXNvbHZlKHJlcSkge1xuXHR2YXIgaWQgPSBtYXBbcmVxXTtcblx0aWYoIShpZCArIDEpKSB7IC8vIGNoZWNrIGZvciBudW1iZXIgb3Igc3RyaW5nXG5cdFx0dmFyIGUgPSBuZXcgRXJyb3IoJ0Nhbm5vdCBmaW5kIG1vZHVsZSBcIicgKyByZXEgKyAnXCIuJyk7XG5cdFx0ZS5jb2RlID0gJ01PRFVMRV9OT1RfRk9VTkQnO1xuXHRcdHRocm93IGU7XG5cdH1cblx0cmV0dXJuIGlkO1xufVxud2VicGFja0NvbnRleHQua2V5cyA9IGZ1bmN0aW9uIHdlYnBhY2tDb250ZXh0S2V5cygpIHtcblx0cmV0dXJuIE9iamVjdC5rZXlzKG1hcCk7XG59O1xud2VicGFja0NvbnRleHQucmVzb2x2ZSA9IHdlYnBhY2tDb250ZXh0UmVzb2x2ZTtcbm1vZHVsZS5leHBvcnRzID0gd2VicGFja0NvbnRleHQ7XG53ZWJwYWNrQ29udGV4dC5pZCA9IFwiLi9ub2RlX21vZHVsZXMvd2VicGFjay9ob3Qgc3luYyBeXFxcXC5cXFxcL2xvZyRcIjsiXSwibWFwcGluZ3MiOiJBQUFBO0FBQ0E7QUFDQTtBQUNBO0FBQ0E7QUFDQTtBQUNBO0FBQ0E7QUFDQTtBQUNBO0FBQ0E7QUFDQTtBQUNBO0FBQ0E7QUFDQTtBQUNBO0FBQ0E7QUFDQTtBQUNBO0FBQ0E7QUFDQTtBQUNBO0FBQ0E7QUFDQTtBQUNBIiwic291cmNlUm9vdCI6IiJ9\n//# sourceURL=webpack-internal:///./node_modules/webpack/hot sync ^\\.\\/log$\n");

/***/ }),

/***/ 0:
/*!**************************************************************************************************!*\
  !*** multi (webpack)-dev-server/client?http://localhost:8080 ./TorrentChain.FrontEnd//index.tsx ***!
  \**************************************************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

__webpack_require__(/*! F:\Development\TorrentChain\TorrentChain\node_modules\webpack-dev-server\client\index.js?http://localhost:8080 */"./node_modules/webpack-dev-server/client/index.js?http://localhost:8080");
module.exports = __webpack_require__(/*! F:\Development\TorrentChain\TorrentChain\TorrentChain.FrontEnd\/index.tsx */"./TorrentChain.FrontEnd/index.tsx");


/***/ })

/******/ });