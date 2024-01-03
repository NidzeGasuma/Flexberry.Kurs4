import { buildValidations } from 'ember-cp-validations';
import EmberFlexberryDataModel from 'ember-flexberry-data/models/model';

import {
  defineProjections,
  ValidationRules,
  Model as Тч_загрMixin
} from '../mixins/regenerated/models/i-i-s-kurs4-тч-загр';

const Validations = buildValidations(ValidationRules, {
  dependentKeys: ['model.i18n.locale'],
});

let Model = EmberFlexberryDataModel.extend(Тч_загрMixin, Validations, {
});

defineProjections(Model);

export default Model;
