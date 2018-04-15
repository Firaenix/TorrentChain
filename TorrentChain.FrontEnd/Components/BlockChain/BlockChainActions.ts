import axios from 'axios';
import { GlobalState } from 'store';

/* actions.js */
export const BlockChainActions = (store: any) => ({
  getBlockChain: async (state: GlobalState): Promise<Partial<GlobalState>> => {
    const response = await axios.get('/api/blockchain');

    return {
      ...state,
      blockChain: response.data
    };
  }
});
