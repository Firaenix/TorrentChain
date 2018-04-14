import * as createStore from 'redux-zero';

const createStoreHack: any = createStore;

export class GlobalState {
  public count: number = 1;
  public dataResponse: any = null;
}

export const store = createStoreHack(new GlobalState());
