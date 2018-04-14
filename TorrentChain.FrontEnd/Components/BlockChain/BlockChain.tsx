import * as React from 'react';
import { connect } from 'redux-zero/react';

import { GlobalState } from '../../store';
import { BlockChainActions } from './BlockChainActions';

interface Props {
  passedDownCount?: number;
  dimitrisCoolNumber?: number;
  internetData?: any;

  increment: () => void;
  decrement: () => void;
  hitApi: () => void;
}

interface State {
  dimitrisCoolNumber: number;
}

export class BlockChainComponent extends React.Component<Props, State> {
  constructor(props: Props) {
    super(props);

    this.state = {
      dimitrisCoolNumber: 0
    };
  }

  public render() {
    return (
      <div className="blockchain-component">
        <div>{this.props.passedDownCount}</div>
        <div>Dimitri: {this.props.dimitrisCoolNumber}</div>
        <div>State Dimitri: {this.state.dimitrisCoolNumber}</div>
        <div>{JSON.stringify(this.props.internetData)}</div>
        <button className="blockchain-button" onClick={this.props.increment}>
          Increment
        </button>
        <button className="blockchain-button-green" onClick={this.props.decrement}>
          Decrement
        </button>
        <button onClick={this.props.hitApi}>hitApi</button>
      </div>
    );
  }
}

const mapToProps = (state: GlobalState): Partial<Props> => ({
  passedDownCount: state.count,
  dimitrisCoolNumber: state.count,
  internetData: state.dataResponse
});

export const BlockChain = connect(mapToProps, BlockChainActions)(BlockChainComponent);
