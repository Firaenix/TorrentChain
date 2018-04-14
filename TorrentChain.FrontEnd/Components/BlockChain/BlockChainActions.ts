import axios from 'axios';
import { GlobalState } from 'store';

/* actions.js */
export const BlockChainActions = (store: any) => ({
  increment: (state: GlobalState): Partial<GlobalState> => ({ count: state.count + 1 }),
  decrement: (state: GlobalState): Partial<GlobalState> => ({ count: state.count - 1 }),

  hitApi: async (state: GlobalState, data: any): Promise<Partial<GlobalState>> => {
    const response = await axios.get('http://ip-api.com/json');

    return {
      ...state,
      dataResponse: response.data
    };
  }
});
