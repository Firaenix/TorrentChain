import { BlockModel } from 'Model/BlockModel';
import * as React from 'react';
import { connect } from 'redux-zero/react';

import { GlobalState } from '../../store';
import { Block } from '../Block';
import { BlockChainActions } from './BlockChainActions';

interface Props {
  blocks: Array<BlockModel>;

  getBlockChain: () => void;
}

export class BlockChainComponent extends React.Component<Props> {
  constructor(props: Props) {
    super(props);

    props.getBlockChain();
  }

  private renderBlocks() {
    const { blocks } = this.props;
    if (!blocks) {
      return <div>No Blocks</div>;
    }

    return blocks.map(x => <Block key={x.hash} block={x} />);
  }

  public render() {
    return this.renderBlocks();
  }
}

export const BlockChain = connect(
  (state: GlobalState): Partial<Props> => ({
    blocks: state.blockChain
  }),
  BlockChainActions
)(BlockChainComponent);
