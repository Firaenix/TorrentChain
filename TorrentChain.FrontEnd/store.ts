import * as createStore from 'redux-zero';

import { BlockModel } from './Model/BlockModel';

const createStoreHack: any = createStore;

export class GlobalState {
  blockChain: Array<BlockModel>;
}

export const store = createStoreHack(new GlobalState());
