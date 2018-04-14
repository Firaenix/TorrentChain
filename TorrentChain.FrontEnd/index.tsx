import './Styles/base.scss';

import { BlockChain } from 'Components/BlockChain/BlockChain';
import * as React from 'react';
import * as ReactDOM from 'react-dom';
import * as ReduxZero from 'redux-zero/react';

import { store } from './store';

ReactDOM.render(
  <ReduxZero.Provider store={store}>
    <BlockChain />
  </ReduxZero.Provider>,
  document.getElementById('root')
);
