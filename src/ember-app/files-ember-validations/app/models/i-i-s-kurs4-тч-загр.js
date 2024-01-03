import {
  defineNamespace,
  defineProjections,
  Model as Тч_загрMixin
} from '../mixins/regenerated/models/i-i-s-kurs4-тч-загр';

import EmberFlexberryDataModel from 'ember-flexberry-data/models/model';

let Model = EmberFlexberryDataModel.extend(Тч_загрMixin, {
});

defineNamespace(Model);
defineProjections(Model);

export default Model;
