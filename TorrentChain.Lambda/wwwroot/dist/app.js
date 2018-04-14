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

/***/ "./TorrentChain.FrontEnd/Components/BlockChain/BlockChain.tsx":
/*!********************************************************************!*\
  !*** ./TorrentChain.FrontEnd/Components/BlockChain/BlockChain.tsx ***!
  \********************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

"use strict";
eval("\r\nvar __extends = (this && this.__extends) || (function () {\r\n    var extendStatics = Object.setPrototypeOf ||\r\n        ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||\r\n        function (d, b) { for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p]; };\r\n    return function (d, b) {\r\n        extendStatics(d, b);\r\n        function __() { this.constructor = d; }\r\n        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());\r\n    };\r\n})();\r\nObject.defineProperty(exports, \"__esModule\", { value: true });\r\nvar React = __webpack_require__(/*! react */ \"./node_modules/react/index.js\");\r\nvar react_1 = __webpack_require__(/*! redux-zero/react */ \"./node_modules/redux-zero/react/index.js\");\r\nvar BlockChainActions_1 = __webpack_require__(/*! ./BlockChainActions */ \"./TorrentChain.FrontEnd/Components/BlockChain/BlockChainActions.ts\");\r\nvar BlockChainComponent = /** @class */ (function (_super) {\r\n    __extends(BlockChainComponent, _super);\r\n    function BlockChainComponent(props) {\r\n        var _this = _super.call(this, props) || this;\r\n        _this.state = {\r\n            dimitrisCoolNumber: 0\r\n        };\r\n        return _this;\r\n    }\r\n    BlockChainComponent.prototype.render = function () {\r\n        return (React.createElement(\"div\", { className: \"blockchain-component\" },\r\n            React.createElement(\"div\", null, this.props.passedDownCount),\r\n            React.createElement(\"div\", null,\r\n                \"Dimitri: \",\r\n                this.props.dimitrisCoolNumber),\r\n            React.createElement(\"div\", null,\r\n                \"State Dimitri: \",\r\n                this.state.dimitrisCoolNumber),\r\n            React.createElement(\"div\", null, JSON.stringify(this.props.internetData)),\r\n            React.createElement(\"button\", { className: \"blockchain-button\", onClick: this.props.increment }, \"Increment\"),\r\n            React.createElement(\"button\", { className: \"blockchain-button-green\", onClick: this.props.decrement }, \"Decrement\"),\r\n            React.createElement(\"button\", { onClick: this.props.hitApi }, \"hitApi\")));\r\n    };\r\n    return BlockChainComponent;\r\n}(React.Component));\r\nexports.BlockChainComponent = BlockChainComponent;\r\nvar mapToProps = function (state) { return ({\r\n    passedDownCount: state.count,\r\n    dimitrisCoolNumber: state.count,\r\n    internetData: state.dataResponse\r\n}); };\r\nexports.BlockChain = react_1.connect(mapToProps, BlockChainActions_1.BlockChainActions)(BlockChainComponent);\r\n//# sourceURL=[module]\n//# sourceMappingURL=data:application/json;charset=utf-8;base64,eyJ2ZXJzaW9uIjozLCJmaWxlIjoiLi9Ub3JyZW50Q2hhaW4uRnJvbnRFbmQvQ29tcG9uZW50cy9CbG9ja0NoYWluL0Jsb2NrQ2hhaW4udHN4LmpzIiwic291cmNlcyI6WyJ3ZWJwYWNrOi8vLy4vVG9ycmVudENoYWluLkZyb250RW5kL0NvbXBvbmVudHMvQmxvY2tDaGFpbi9CbG9ja0NoYWluLnRzeD84MzViIl0sInNvdXJjZXNDb250ZW50IjpbImltcG9ydCAqIGFzIFJlYWN0IGZyb20gJ3JlYWN0JztcbmltcG9ydCB7IGNvbm5lY3QgfSBmcm9tICdyZWR1eC16ZXJvL3JlYWN0JztcblxuaW1wb3J0IHsgR2xvYmFsU3RhdGUgfSBmcm9tICcuLi8uLi9zdG9yZSc7XG5pbXBvcnQgeyBCbG9ja0NoYWluQWN0aW9ucyB9IGZyb20gJy4vQmxvY2tDaGFpbkFjdGlvbnMnO1xuXG5pbnRlcmZhY2UgUHJvcHMge1xuICBwYXNzZWREb3duQ291bnQ/OiBudW1iZXI7XG4gIGRpbWl0cmlzQ29vbE51bWJlcj86IG51bWJlcjtcbiAgaW50ZXJuZXREYXRhPzogYW55O1xuXG4gIGluY3JlbWVudDogKCkgPT4gdm9pZDtcbiAgZGVjcmVtZW50OiAoKSA9PiB2b2lkO1xuICBoaXRBcGk6ICgpID0+IHZvaWQ7XG59XG5cbmludGVyZmFjZSBTdGF0ZSB7XG4gIGRpbWl0cmlzQ29vbE51bWJlcjogbnVtYmVyO1xufVxuXG5leHBvcnQgY2xhc3MgQmxvY2tDaGFpbkNvbXBvbmVudCBleHRlbmRzIFJlYWN0LkNvbXBvbmVudDxQcm9wcywgU3RhdGU+IHtcbiAgY29uc3RydWN0b3IocHJvcHM6IFByb3BzKSB7XG4gICAgc3VwZXIocHJvcHMpO1xuXG4gICAgdGhpcy5zdGF0ZSA9IHtcbiAgICAgIGRpbWl0cmlzQ29vbE51bWJlcjogMFxuICAgIH07XG4gIH1cblxuICBwdWJsaWMgcmVuZGVyKCkge1xuICAgIHJldHVybiAoXG4gICAgICA8ZGl2IGNsYXNzTmFtZT1cImJsb2NrY2hhaW4tY29tcG9uZW50XCI+XG4gICAgICAgIDxkaXY+e3RoaXMucHJvcHMucGFzc2VkRG93bkNvdW50fTwvZGl2PlxuICAgICAgICA8ZGl2PkRpbWl0cmk6IHt0aGlzLnByb3BzLmRpbWl0cmlzQ29vbE51bWJlcn08L2Rpdj5cbiAgICAgICAgPGRpdj5TdGF0ZSBEaW1pdHJpOiB7dGhpcy5zdGF0ZS5kaW1pdHJpc0Nvb2xOdW1iZXJ9PC9kaXY+XG4gICAgICAgIDxkaXY+e0pTT04uc3RyaW5naWZ5KHRoaXMucHJvcHMuaW50ZXJuZXREYXRhKX08L2Rpdj5cbiAgICAgICAgPGJ1dHRvbiBjbGFzc05hbWU9XCJibG9ja2NoYWluLWJ1dHRvblwiIG9uQ2xpY2s9e3RoaXMucHJvcHMuaW5jcmVtZW50fT5cbiAgICAgICAgICBJbmNyZW1lbnRcbiAgICAgICAgPC9idXR0b24+XG4gICAgICAgIDxidXR0b24gY2xhc3NOYW1lPVwiYmxvY2tjaGFpbi1idXR0b24tZ3JlZW5cIiBvbkNsaWNrPXt0aGlzLnByb3BzLmRlY3JlbWVudH0+XG4gICAgICAgICAgRGVjcmVtZW50XG4gICAgICAgIDwvYnV0dG9uPlxuICAgICAgICA8YnV0dG9uIG9uQ2xpY2s9e3RoaXMucHJvcHMuaGl0QXBpfT5oaXRBcGk8L2J1dHRvbj5cbiAgICAgIDwvZGl2PlxuICAgICk7XG4gIH1cbn1cblxuY29uc3QgbWFwVG9Qcm9wcyA9IChzdGF0ZTogR2xvYmFsU3RhdGUpOiBQYXJ0aWFsPFByb3BzPiA9PiAoe1xuICBwYXNzZWREb3duQ291bnQ6IHN0YXRlLmNvdW50LFxuICBkaW1pdHJpc0Nvb2xOdW1iZXI6IHN0YXRlLmNvdW50LFxuICBpbnRlcm5ldERhdGE6IHN0YXRlLmRhdGFSZXNwb25zZVxufSk7XG5cbmV4cG9ydCBjb25zdCBCbG9ja0NoYWluID0gY29ubmVjdChtYXBUb1Byb3BzLCBCbG9ja0NoYWluQWN0aW9ucykoQmxvY2tDaGFpbkNvbXBvbmVudCk7XG4iXSwibWFwcGluZ3MiOiI7Ozs7Ozs7Ozs7OztBQUFBO0FBQ0E7QUFHQTtBQWdCQTtBQUFBO0FBQ0E7QUFBQTtBQUdBO0FBQ0E7QUFDQTs7QUFDQTtBQUVBO0FBQ0E7QUFFQTtBQUNBOztBQUFBO0FBQ0E7O0FBQUE7QUFDQTtBQUNBO0FBR0E7QUFHQTtBQUdBO0FBQ0E7QUFBQTtBQTFCQTtBQTRCQTtBQUNBO0FBQ0E7QUFDQTtBQUNBO0FBRUE7Iiwic291cmNlUm9vdCI6IiJ9\n//# sourceURL=webpack-internal:///./TorrentChain.FrontEnd/Components/BlockChain/BlockChain.tsx\n");

/***/ }),

/***/ "./TorrentChain.FrontEnd/Components/BlockChain/BlockChainActions.ts":
/*!**************************************************************************!*\
  !*** ./TorrentChain.FrontEnd/Components/BlockChain/BlockChainActions.ts ***!
  \**************************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

"use strict";
eval("\r\nvar __assign = (this && this.__assign) || Object.assign || function(t) {\r\n    for (var s, i = 1, n = arguments.length; i < n; i++) {\r\n        s = arguments[i];\r\n        for (var p in s) if (Object.prototype.hasOwnProperty.call(s, p))\r\n            t[p] = s[p];\r\n    }\r\n    return t;\r\n};\r\nvar __awaiter = (this && this.__awaiter) || function (thisArg, _arguments, P, generator) {\r\n    return new (P || (P = Promise))(function (resolve, reject) {\r\n        function fulfilled(value) { try { step(generator.next(value)); } catch (e) { reject(e); } }\r\n        function rejected(value) { try { step(generator[\"throw\"](value)); } catch (e) { reject(e); } }\r\n        function step(result) { result.done ? resolve(result.value) : new P(function (resolve) { resolve(result.value); }).then(fulfilled, rejected); }\r\n        step((generator = generator.apply(thisArg, _arguments || [])).next());\r\n    });\r\n};\r\nvar __generator = (this && this.__generator) || function (thisArg, body) {\r\n    var _ = { label: 0, sent: function() { if (t[0] & 1) throw t[1]; return t[1]; }, trys: [], ops: [] }, f, y, t, g;\r\n    return g = { next: verb(0), \"throw\": verb(1), \"return\": verb(2) }, typeof Symbol === \"function\" && (g[Symbol.iterator] = function() { return this; }), g;\r\n    function verb(n) { return function (v) { return step([n, v]); }; }\r\n    function step(op) {\r\n        if (f) throw new TypeError(\"Generator is already executing.\");\r\n        while (_) try {\r\n            if (f = 1, y && (t = y[op[0] & 2 ? \"return\" : op[0] ? \"throw\" : \"next\"]) && !(t = t.call(y, op[1])).done) return t;\r\n            if (y = 0, t) op = [0, t.value];\r\n            switch (op[0]) {\r\n                case 0: case 1: t = op; break;\r\n                case 4: _.label++; return { value: op[1], done: false };\r\n                case 5: _.label++; y = op[1]; op = [0]; continue;\r\n                case 7: op = _.ops.pop(); _.trys.pop(); continue;\r\n                default:\r\n                    if (!(t = _.trys, t = t.length > 0 && t[t.length - 1]) && (op[0] === 6 || op[0] === 2)) { _ = 0; continue; }\r\n                    if (op[0] === 3 && (!t || (op[1] > t[0] && op[1] < t[3]))) { _.label = op[1]; break; }\r\n                    if (op[0] === 6 && _.label < t[1]) { _.label = t[1]; t = op; break; }\r\n                    if (t && _.label < t[2]) { _.label = t[2]; _.ops.push(op); break; }\r\n                    if (t[2]) _.ops.pop();\r\n                    _.trys.pop(); continue;\r\n            }\r\n            op = body.call(thisArg, _);\r\n        } catch (e) { op = [6, e]; y = 0; } finally { f = t = 0; }\r\n        if (op[0] & 5) throw op[1]; return { value: op[0] ? op[1] : void 0, done: true };\r\n    }\r\n};\r\nvar _this = this;\r\nObject.defineProperty(exports, \"__esModule\", { value: true });\r\nvar axios_1 = __webpack_require__(/*! axios */ \"./node_modules/axios/index.js\");\r\n/* actions.js */\r\nexports.BlockChainActions = function (store) { return ({\r\n    increment: function (state) { return ({ count: state.count + 1 }); },\r\n    decrement: function (state) { return ({ count: state.count - 1 }); },\r\n    hitApi: function (state, data) { return __awaiter(_this, void 0, void 0, function () {\r\n        var response;\r\n        return __generator(this, function (_a) {\r\n            switch (_a.label) {\r\n                case 0: return [4 /*yield*/, axios_1.default.get('http://ip-api.com/json')];\r\n                case 1:\r\n                    response = _a.sent();\r\n                    return [2 /*return*/, __assign({}, state, { dataResponse: response.data })];\r\n            }\r\n        });\r\n    }); }\r\n}); };\r\n//# sourceURL=[module]\n//# sourceMappingURL=data:application/json;charset=utf-8;base64,eyJ2ZXJzaW9uIjozLCJmaWxlIjoiLi9Ub3JyZW50Q2hhaW4uRnJvbnRFbmQvQ29tcG9uZW50cy9CbG9ja0NoYWluL0Jsb2NrQ2hhaW5BY3Rpb25zLnRzLmpzIiwic291cmNlcyI6WyJ3ZWJwYWNrOi8vLy4vVG9ycmVudENoYWluLkZyb250RW5kL0NvbXBvbmVudHMvQmxvY2tDaGFpbi9CbG9ja0NoYWluQWN0aW9ucy50cz8wMWExIl0sInNvdXJjZXNDb250ZW50IjpbImltcG9ydCBheGlvcyBmcm9tICdheGlvcyc7XG5pbXBvcnQgeyBHbG9iYWxTdGF0ZSB9IGZyb20gJ3N0b3JlJztcblxuLyogYWN0aW9ucy5qcyAqL1xuZXhwb3J0IGNvbnN0IEJsb2NrQ2hhaW5BY3Rpb25zID0gKHN0b3JlOiBhbnkpID0+ICh7XG4gIGluY3JlbWVudDogKHN0YXRlOiBHbG9iYWxTdGF0ZSk6IFBhcnRpYWw8R2xvYmFsU3RhdGU+ID0+ICh7IGNvdW50OiBzdGF0ZS5jb3VudCArIDEgfSksXG4gIGRlY3JlbWVudDogKHN0YXRlOiBHbG9iYWxTdGF0ZSk6IFBhcnRpYWw8R2xvYmFsU3RhdGU+ID0+ICh7IGNvdW50OiBzdGF0ZS5jb3VudCAtIDEgfSksXG5cbiAgaGl0QXBpOiBhc3luYyAoc3RhdGU6IEdsb2JhbFN0YXRlLCBkYXRhOiBhbnkpOiBQcm9taXNlPFBhcnRpYWw8R2xvYmFsU3RhdGU+PiA9PiB7XG4gICAgY29uc3QgcmVzcG9uc2UgPSBhd2FpdCBheGlvcy5nZXQoJ2h0dHA6Ly9pcC1hcGkuY29tL2pzb24nKTtcblxuICAgIHJldHVybiB7XG4gICAgICAuLi5zdGF0ZSxcbiAgICAgIGRhdGFSZXNwb25zZTogcmVzcG9uc2UuZGF0YVxuICAgIH07XG4gIH1cbn0pO1xuIl0sIm1hcHBpbmdzIjoiOzs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7Ozs7OztBQUFBOztBQUFBO0FBR0E7QUFDQTtBQUNBO0FBQ0E7QUFFQTs7OztBQUNBOztBQUFBO0FBRUE7OztBQUlBO0FBQ0E7Iiwic291cmNlUm9vdCI6IiJ9\n//# sourceURL=webpack-internal:///./TorrentChain.FrontEnd/Components/BlockChain/BlockChainActions.ts\n");

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
eval("\r\nObject.defineProperty(exports, \"__esModule\", { value: true });\r\nvar createStore = __webpack_require__(/*! redux-zero */ \"./node_modules/redux-zero/dist/redux-zero.js\");\r\nvar createStoreHack = createStore;\r\nvar GlobalState = /** @class */ (function () {\r\n    function GlobalState() {\r\n        this.count = 1;\r\n        this.dataResponse = null;\r\n    }\r\n    return GlobalState;\r\n}());\r\nexports.GlobalState = GlobalState;\r\nexports.store = createStoreHack(new GlobalState());\r\n//# sourceURL=[module]\n//# sourceMappingURL=data:application/json;charset=utf-8;base64,eyJ2ZXJzaW9uIjozLCJmaWxlIjoiLi9Ub3JyZW50Q2hhaW4uRnJvbnRFbmQvc3RvcmUudHMuanMiLCJzb3VyY2VzIjpbIndlYnBhY2s6Ly8vLi9Ub3JyZW50Q2hhaW4uRnJvbnRFbmQvc3RvcmUudHM/YzlkMiJdLCJzb3VyY2VzQ29udGVudCI6WyJpbXBvcnQgKiBhcyBjcmVhdGVTdG9yZSBmcm9tICdyZWR1eC16ZXJvJztcblxuY29uc3QgY3JlYXRlU3RvcmVIYWNrOiBhbnkgPSBjcmVhdGVTdG9yZTtcblxuZXhwb3J0IGNsYXNzIEdsb2JhbFN0YXRlIHtcbiAgcHVibGljIGNvdW50OiBudW1iZXIgPSAxO1xuICBwdWJsaWMgZGF0YVJlc3BvbnNlOiBhbnkgPSBudWxsO1xufVxuXG5leHBvcnQgY29uc3Qgc3RvcmUgPSBjcmVhdGVTdG9yZUhhY2sobmV3IEdsb2JhbFN0YXRlKCkpO1xuIl0sIm1hcHBpbmdzIjoiOztBQUFBO0FBRUE7QUFFQTtBQUFBO0FBQ0E7QUFDQTtBQUNBO0FBQUE7QUFBQTtBQUhBO0FBS0E7Iiwic291cmNlUm9vdCI6IiJ9\n//# sourceURL=webpack-internal:///./TorrentChain.FrontEnd/store.ts\n");

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