import {
  defineNamespace,
  defineProjections,
  Model as КонвФайлыMixin
} from '../mixins/regenerated/models/i-i-s-kurs4-конв-файлы';

import EmberFlexberryDataModel from 'ember-flexberry-data/models/model';

let Model = EmberFlexberryDataModel.extend(КонвФайлыMixin, {
});

defineNamespace(Model);
defineProjections(Model);

export default Model;
