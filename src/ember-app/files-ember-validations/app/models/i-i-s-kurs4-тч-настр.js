import {
  defineNamespace,
  defineProjections,
  Model as Тч_настрMixin
} from '../mixins/regenerated/models/i-i-s-kurs4-тч-настр';

import EmberFlexberryDataModel from 'ember-flexberry-data/models/model';

let Model = EmberFlexberryDataModel.extend(Тч_настрMixin, {
});

defineNamespace(Model);
defineProjections(Model);

export default Model;
